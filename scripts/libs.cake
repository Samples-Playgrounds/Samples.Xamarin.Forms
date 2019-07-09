#load "./nuget-restore.cake"

LibSourceSolutions = GetFiles(source_solutions);
LibSourceProjects = GetFiles(source_projects);

//---------------------------------------------------------------------------------------
Task("libs")
    .IsDependentOn ("nuget-restore-libs")
    .IsDependentOn ("libs-msbuild-solutions")
    .IsDependentOn ("libs-msbuild-projects")
    .IsDependentOn ("libs-dotnet-solutions")
    .IsDependentOn ("libs-dotnet-projects")
    .Does
    (
        () =>
        {
            return;
        }
    );


Task("libs-msbuild-solutions")
    .Does
    (
        () =>
        {
            foreach(FilePath sln in LibSourceSolutions)
            {
                MSBuild
                (
                    sln.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Debug",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
                MSBuild
                (
                    sln.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Release",
                        BinaryLogger = new MSBuildBinaryLogSettings 
                        { 
                            Enabled = true, 
                            FileName = MakeAbsolute(new FilePath("./output/libs.binlog"))
                                            .FullPath 
                        }
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                    // c.Targets.Clear();
                    // c.Targets.Add("Pack");
                    // c.Properties.Add("PackageOutputPath", new [] { MakeAbsolute(outputPath).FullPath });
                    // c.Properties.Add("PackageRequireLicenseAcceptance", new [] { "true" });
                    // c.Properties.Add("DesignTimeBuild", new [] { "false" });
                    // c.Properties.Add("AndroidSdkBuildToolsVersion", new [] { "28.0.3" });
                );
            }

            return;
        }
    );

Task("libs-dotnet-solutions")
    .Does
    (
        () =>
        {
            foreach(FilePath sln in LibSourceSolutions)
            {
                DotNetCoreBuild
                (
                    sln.ToString(),
                    // https://cakebuild.net/api/Cake.Common.Tools.DotNetCore.MSBuild/DotNetCoreMSBuildSettings/
                    new DotNetCoreBuildSettings
                    {
                        Configuration = "Debug",
                        DiagnosticOutput = true,
                        // DetailedSummary = true,
                        //DistributedFileLogger = true,
                        //DistributedFileLogger = true,
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
                DotNetCoreBuild
                (
                    sln.ToString(),
                    new DotNetCoreBuildSettings
                    {
                        Configuration = "Release",
                        DiagnosticOutput = true,
                        // DetailedSummary = true,
                        //DistributedFileLogger = true,
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
            }

            return;
        }
    );

Task("libs-msbuild-projects")
    .Does
    (
        () =>
        {
            foreach(FilePath prj in LibSourceProjects)
            {
                MSBuild
                (
                    prj.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Debug",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
                MSBuild
                (
                    prj.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Release",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
            }

            return;
        }
    );

Task("libs-dotnet-projects")
    .Does
    (
        () =>
        {
            foreach(FilePath prj in LibSourceProjects)
            {
                DotNetCoreBuild
                (
                    prj.ToString(),
                    new DotNetCoreBuildSettings
                    {
                        Configuration = "Debug",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
                DotNetCoreBuild
                (
                    prj.ToString(),
                    new DotNetCoreBuildSettings
                    {
                        Configuration = "Release",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
            }

            return;
        }
    );
//---------------------------------------------------------------------------------------
