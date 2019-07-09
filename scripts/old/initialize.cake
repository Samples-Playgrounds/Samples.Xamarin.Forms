#addin nuget:?package=Cake.FileHelpers

FilePathCollection LibSourceSolutions = GetFiles($"./source/**/*.sln");
FilePathCollection LibSourceProjects = GetFiles($"./source/**/*.csproj");

// https://stackoverflow.com/questions/38761827/cake-build-script-progress

// https://cakebuild.net/api/Cake.Core/SetupContext/
IReadOnlyCollection<ICakeTaskInfo> tasks_registered;
IReadOnlyCollection<ICakeTaskInfo> tasks_to_execute;
Setup
(
    context =>
    {
        tasks_registered = Tasks;
        tasks_to_execute = context.TasksToExecute;

        return;
    }
);

Task("usage")
    .Does
    (
        () =>
        {
            Information($"usage:");
            foreach(ICakeTaskInfo task in tasks_registered)
            {
                Information($"    --{task.Name}");
                IReadOnlyList<CakeTaskDependency> dependencies = task.Dependencies;
                IReadOnlyList<CakeTaskDependency> dependees = task.Dependees;
                Information($"          Dependencies:");
                foreach(CakeTaskDependency task_d in dependencies)
                {
                    Information($"          {task_d.Name}");
                }

            }
        }
    );

Task ("clean")
    .IsDependentOn ("clean-externals")
    .Does
    (
        () =>
        {
            if (DirectoryExists ("./output/"))
            {
                DeleteDirectory ("./output", true);
            }

            Parallel.Invoke
            (
                () =>
                {
                    DirectoryPathCollection dirs = GetDirectories("./**/bin/");
                    foreach(DirectoryPath dir in dirs)
                    {
                        Information("Directory: {0}", dir);
                        DeleteDirectory
                                (
                                    dir, 
                                    new DeleteDirectorySettings 
                                    {
                                        Recursive = true,
                                        Force = true
                                    }
                                );
                    }
                    return;
                },
                () =>
                {
                    DirectoryPathCollection dirs = GetDirectories("./**/obj/");
                    foreach(DirectoryPath dir in dirs)
                    {
                        Information("Directory: {0}", dir);
                        DeleteDirectory
                                (
                                    dir, 
                                    new DeleteDirectorySettings 
                                    {
                                        Recursive = true,
                                        Force = true
                                    }
                                );
                    }
                    return;
                }
            );

            CreateDirectory("./output");

            return;
        }
    );

Task ("clean-externals")
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
                                {"target",      "clean"},
                            },
                        }
                    );
            }

            return;
        }
    );

Task("nuget-restore")
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
            files = GetFiles("./externals/**/samples/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }
            files = GetFiles("./externals/**/tests/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }
            files = GetFiles("./externals/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            files = GetFiles("./source/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }
            files = GetFiles("./samples/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }
            files = GetFiles("./tests/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
                NuGetRestore(file);
            }

            return;
        }
    );
