
//---------------------------------------------------------------------------------------
Task("nuget-restore")
    .IsDependentOn("nuget-restore-externals")
    .IsDependentOn("nuget-restore-libs")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task("nuget-restore-externals")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;

            files = GetFiles("./externals/**/source/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            return;
        }
    );

Task("nuget-restore-libs")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;
            files = GetFiles("./source/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }
            files = GetFiles("./source/**/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            return;
        }
    );

Task("nuget-restore-samples")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;
            files = GetFiles("./samples/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            return;
        }
    );

Task("nuget-restore-tests")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;

            files = GetFiles("./tests/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            return;
        }
    );
//---------------------------------------------------------------------------------------
