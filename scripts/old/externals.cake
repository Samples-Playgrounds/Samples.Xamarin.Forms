#addin nuget:?package=Cake.Git

// https://github.com/abeggchr/cake-gradle
// #addin nuget:?package=Cake.Gradle

#load "./externals/repos-AndroidSupport.cake"
#load "./externals/repos-AndroidX.cake"
#load "./externals/repos-Google.Play.Services.cake"
#load "./externals/repos-Firebase.cake"
#load "./externals/repos-Material.cake"
#load "./externals/repos-Awsome_Android_UI.cake"
#load "./externals/repos-GooglePlayServices-AdMob.cake"
#load "./externals/repos-Office365-Fabric.cake"

Dictionary<string, Dictionary<string, string> > Repositories = null;
Repositories = new Dictionary<string, Dictionary<string, string> >();

string path_output_repos = System.IO.Path.Combine
                                            (
                                                new string[]
                                                {
                                                    "..",
                                                    "output",
                                                    "repos",
                                                }
                                            );


//-------------------------------------------------------------------------------------------------
IEnumerable<string> redirectedStandardOutput;
int exitCodeWithArgument;

exitCodeWithArgument =
								StartProcess
								(
									"git",
									new ProcessSettings
									{
										Arguments = "config user.name",
										RedirectStandardOutput = true
									},
									out redirectedStandardOutput
								);

string git_user = redirectedStandardOutput.LastOrDefault();
Information($"git user: {git_user}");

exitCodeWithArgument =
								StartProcess
								(
									"git",
									new ProcessSettings
									{
										Arguments = "config user.email",
										RedirectStandardOutput = true
									},
									out redirectedStandardOutput
								);

string git_email = redirectedStandardOutput.LastOrDefault();
Information($"git email: {git_email}");
//-------------------------------------------------------------------------------------------------


Task ("externals")
    .IsDependentOn ("externals-clone-repos")
    .IsDependentOn ("externals-download-code")
    .IsDependentOn ("externals-build-cake")
    .IsDependentOn ("externals-build-gradle")
    .IsDependentOn ("externals-build-xcode")
    .Does
    (
        () =>
        {
        }
    );

Task ("externals-clone-repos")
    .Does
    (
        () =>
        {
            Information("externals ...");

            Repositories = Repositories
                                .Concat(Repositories_AndroidSupport)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;
            Repositories = Repositories
                                .Concat(Repositories_AndroidX)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;
            Repositories = Repositories
                                .Concat(Repositories_GooglePLayServices)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;
            Repositories = Repositories
                                .Concat(Repositories_Firebase)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;
            Repositories = Repositories
                                .Concat(Repositories_Material)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;
            Repositories = Repositories
                                .Concat(Repos_Awsome_Android_UI)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                ;


            foreach(KeyValuePair<string, Dictionary<string, string> > repo_group in Repositories)
            {
                string path_repo_group = System.IO.Path.Combine(path_output_repos, repo_group.Key);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"    group dir  = {repo_group.Key}");

                EnsureDirectoryExists(path_repo_group);

                foreach(KeyValuePair<string, string> repo in repo_group.Value)
                {
                    string repo_git_url = $"{repo.Value}";
                    string repo_git_dir = $"{path_repo_group}/{repo.Key}";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"            repo_git_url = {repo_git_url}");
                    Console.WriteLine($"            repo_git_dir = {repo_git_dir}");

                    if (! DirectoryExists($"repo_git_dir"))
                    {
                        if (repo_git_url.EndsWith(".zip"))
                        {
                            Information($"            downloading .....");
                            DownloadFile
                                (
                                    repo_git_url,
                                    repo_git_dir
                                );
                        }
                        else if (repo_git_url.EndsWith(".git"))
                        {
                            Information($"        git clone .....");
                            GitClone
                                (
                                    repo_git_url,
                                    repo_git_dir,
                                    new GitCloneSettings
                                    {
                                        RecurseSubmodules = true,
                                    }
                                );
                        }
                        else
                        {
                            try
                            {
                                repo_git_url = $"{repo_git_url}.git";
                                Information($"        git clone .....");
                                GitClone
                                    (
                                        repo_git_url,
                                        repo_git_dir,
                                        new GitCloneSettings
                                        {
                                            RecurseSubmodules = true,
                                        }
                                    );
                            }
                            catch (System.Exception)
                            {
                                Error($"Could not clone: {repo_git_url}");
                            }
                        }
                    }


                }
            }
            Console.ResetColor();

            return;
        }
    );


Task ("externals-build-cake")
    //.IsDependentOn ("externals-base")
    // .WithCriteria (!FileExists ("./externals/HolisticWare.Core.Math.Statistics.aar"))
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

Task ("externals-build-gradle")
    //.IsDependentOn ("externals-base")
    // .WithCriteria (!FileExists ("./externals/HolisticWare.Core.Math.Statistics.aar"))
    .Does
    (
        () =>
        {
        }
    );
Task ("externals-folders")
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

Task("externals-build-gradle")
.Does
(
    () =>
    {
        //Gradle.WithArguments("--version").Run();

        foreach (KeyValuePair<string, Dictionary<string, string> > repo_group in Repositories)
        {
            //Gradle.FromPath("./example").WithTask("hello").Run();
        }

        return;
    }
);
Task("externals-update-git-repos")
.Does
(
    () =>
    {
		// https://stackoverflow.com/questions/42918647/need-to-get-the-details-of-the-modified-files-in-gitpull-method-in-cake-script


        foreach (KeyValuePair<string, Dictionary<string, string> > repo_group in Repositories)
        {


			if (DirectoryExists(repo_group.Key))
			{
				Warning ($"       Folder exists ../{repo_group.Key}");
				Warning ($"       git pull ../{repo_group.Key}");
				string directory = System.IO.Path.Combine("..", repo_group.Key);

				exitCodeWithArgument =
										StartProcess
										(
											"git",
											new ProcessSettings
											{
												Arguments = $"-C ../{repo_group.Key} pull",
												RedirectStandardOutput = true
											},
											out redirectedStandardOutput
										);

				string git_pull = string.Join(Environment.NewLine, redirectedStandardOutput);

				Information($"git pull: {git_pull}");
				Information($"          {git_pull}");

				GitMergeResult result = GitPull
											(
												directory, git_user, git_email
											);

				if (result.Status == GitMergeStatus.UpToDate)
				{
		            Information($"         dir  = ../{repo_group.Key}");
		            Information($"            up to date");
				}
				else
				{
		            Error($"         dir  = ../{repo_group.Key}");
		            Error($"            dirty - commit or stash");
				}
			}
			else
			{
                foreach(KeyValuePair<string, string> kvp in repo_group.Value)
                {

                }
				// exitCodeWithArgument =
				// 						StartProcess
				// 						(
				// 							"git",
				// 							new ProcessSettings
				// 							{
				// 								Arguments = $"-C {repo.Key.Folder} clone",
				// 								RedirectStandardOutput = true
				// 							},
				// 							out redirectedStandardOutput
				// 						);

				string git_pull = string.Join(Environment.NewLine, redirectedStandardOutput);
				Information($"git email: {git_pull}");
			}
        }
    }
);
