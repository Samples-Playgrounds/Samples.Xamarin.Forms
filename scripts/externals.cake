#load "./nuget-restore.cake"

Task ("externals")
    //.IsDependentOn ("externals-base")
    // .WithCriteria (!FileExists ("./externals/HolisticWare.Core.Math.Statistics.aar"))
    .Does
    (
        () =>
        {
            Information("externals ...");

            string [] folders = new string[]
            {
                "./externals/",
                "./externals/results/",
                "./externals/results/unit-tests/",
            };

            foreach(string folder in folders)
            {
                Information($"    creating ...{folder}");
                if (!DirectoryExists (folder))
                {
                    CreateDirectory (folder);
                }
            }

            Information("    downloading ...");

            // if ( ! string.IsNullOrEmpty(AAR_URL) )
            // {
            // 	//DownloadFile (AAR_URL, "./externals/HolisticWare.Core.Math.Statistics.aar");
            // }
        }
    );

IEnumerable<(string RepoName, string Url)> Externals = null;

Task("externals-code-download")
    .Does
    (
        () =>
        {
            string directory = "./externals/code-repos/";
			EnsureDirectoryExists(directory);
            foreach
                (
                    string file in System.IO.Directory.GetFiles
                                                            (
                                                                "./scripts/", 
                                                                "*.csv",
                                                                SearchOption.AllDirectories
                                                            )
                )
            {
                Information($"file = {file}");

                string[] list = System.IO.File.ReadAllLines(file);
                foreach(string line in list)
                {
                    Information($"  code = {line}");
                    string[] parts = line.Split(new char[] {','});
                    string name = parts[0];
                    string url = parts[1];
                    Information($"      name = {name}");
                    Information($"      utl  = {url}");

                    if (!FileExists($"./{directory}/{name}"))
                    {
                        if ( ! url.EndsWith("/archive/master.zip"))
                        {
                            url = string.Concat(url, "/archive/master.zip");
                        }

                        Information ($"DownloadFile(${url}, ./{directory}/{name});");
                        DownloadFile($"{url}", $"./{directory}/{name}.zip");

                        // CurlDownloadFile
                        // 	(
                        // 		new Uri(url.Value),
                        // 		new CurlDownloadSettings
                        // 		{
                        // 			OutputPaths = new FilePath[] { $"./externals/{url}" }
                        // 		}
                        // 	);
                    }

                    try
                    {
                        Information ($"Unzip (./externals/{url}, ./externals/);");
                        Unzip ($"./{directory}/{name}.zip", $"./{directory}/{name}");
                    }
                    catch (System.Exception exc)
                    {
                        Error ($"exception : {exc?.Message}");
                    }
                }

            }

            return;


            return;
        }
    );

Task("externals-code-build")
    .IsDependentOn ("nuget-restore")
    .Does
    (
        () =>
        {
            FilePathCollection files = GetFiles("./external*/**/build.cake");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                CakeExecuteScript
                    (
                        file,
                        new CakeSettings
                        {
                            Verbosity = Verbosity.Diagnostic,
                            Arguments = new Dictionary<string, string>()
                            {
                                //{"verbosity",   "diagnostic"},
                                {"target",      "libs"},
                            },
                        }
                    );
            }

            return;
        }
    );
