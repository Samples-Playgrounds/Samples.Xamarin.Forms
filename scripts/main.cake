string[] folder_patterns = new string[]
{
    "./externals/",
    "./source/**/bin/",
    "./source/**/obj/",
};

string[] file_patterns = new string[]
{
    "./**/*.binlog",
};

//---------------------------------------------------------------------------------------
Task ("clean")
    .Does
    (
        () =>
        {
            RunTarget("clean-folders");
            RunTarget("clean-files");
        }
    );

Task ("clean-folders")
    .Does
    (
        () =>
        {
            foreach(string folder in folder_patterns)
            {
                DirectoryPathCollection directories = GetDirectories(folder);
                foreach(DirectoryPath dp in directories)
                {
                    Information($"Directory: {dp}");

                    if (DirectoryExists (dp))
                    {
                        DeleteDirectory 
                                    (
                                        dp, 
                                        new DeleteDirectorySettings 
                                        {
                                            Recursive = true,
                                            Force = true
                                        }
                                    );
                    }
                }                
            }


            return;
        }
    );

Task ("clean-files")
    .Does
    (
        () =>
        {
            foreach(string file in file_patterns)
            {
                FilePathCollection files = GetFiles(file);
                foreach(FilePath fp in files)
                {
                    Information($"File: {fp}");

                    if (FileExists (fp))
                    {
                        DeleteFile (fp);
                    }
                }                
            }


            return;
        }
    );


Task ("help")
    .Does
    (
        () =>
        {
            Information("usage:");
            Information("   sh ./build.sh --target=\"\"");
            Information("   targets:");
            Information("       clean");
            Information("       clean-folders");
            Information("       clean-files");
            Information("       clean-externals");
            Information("       ");

            Information("       externals");
            Information("       externals-clone-repos");
            Information("       externals-build-cake");
            Information("       externals-build-gradle");
            Information("       externals-folders");
            Information("       ");

            Information("       libs");
            Information("       Default = libs");
            Information("       samples");
            Information("       nuget");
            Information("       ");

            Information("       bechmark-tests-nunit");
            Information("       bechmark-tests-xunit");
            Information("       bechmark-tests-mstest");
            Information("       ");
            
            Information("       coverage-xunit");
            Information("       ");
            
        }
    );

//---------------------------------------------------------------------------------------

