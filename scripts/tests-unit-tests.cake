//---------------------------------------------------------------------------------------
Task("unit-tests")
    .IsDependentOn("libs")
    .Does
    (
        () =>
        {
            try
            {
                RunTarget("unit-tests-nunit");
            }
            catch (System.Exception)
            {
            }
            try
            {
                RunTarget("unit-tests-xunit");
            }
            catch (System.Exception)
            {
            }
            try
            {
                RunTarget("unit-tests-mstest");
            }
            catch (System.Exception)
            {
            }

            return;
        }
    );

var reports = Directory("./externals/results/unit-tests/");


Task("unit-tests-nunit")
    .Does
    (
        () =>
        {
            FilePathCollection UnitTestsNUnitAssemblies;
            FilePathCollection UnitTestsNUnitProjects = GetFiles($"./tests/unit-tests/project-references/**/*.NUnit.csproj");

            foreach(FilePath prj in UnitTestsNUnitProjects)
            {
                Information($"MSBuild ........................ {prj}");
                MSBuild
                (
                    prj.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Debug",
                    }
                    .WithProperty("DefineConstants", "TRACE;DEBUG;NUNIT")
                );
                MSBuild
                (
                    prj.ToString(),
                    new MSBuildSettings
                    {
                        Configuration = "Release",
                    }
                    .WithProperty("DefineConstants", "TRACE;NUNIT")
                );
            }

            UnitTestsNUnitAssemblies = GetFiles($"./tests/unit-tests/project-references/**/bin/Debug/*.NUnit.dll");

            foreach(FilePath asm in UnitTestsNUnitAssemblies)
            {
                Information($"testing ................ {asm}");
            }

            NUnit3
            (
                UnitTestsNUnitAssemblies,
                new NUnit3Settings
                {
                    OutputFile = "./externals/results/unit-tests/Nunit3.1.txt",
                }
            );

            UnitTestsNUnitAssemblies = GetFiles($"./tests/unit-tests/project-references/**/bin/Release/*.NUnit.dll");

            foreach(FilePath asm in UnitTestsNUnitAssemblies)
            {
                Information($"testing ................ {asm}");
            }

            NUnit3
            (
                UnitTestsNUnitAssemblies,
                new NUnit3Settings
                {
                    OutputFile = "./externals/results/unit-tests/Nunit3.2.txt",
                }
            );
            return;
        }
    );

Task("unit-tests-xunit")
    .Does
    (
        () =>
        {
            try
            {
                MSBuild
                (
                    "./tests/unit-tests/project-references/UnitTests.XUnit/UnitTests.XUnit.csproj",
                    new MSBuildSettings
                    {
                        Configuration = "Debug",
                    }.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;XUNIT")
                );
                DotNetCoreTest
                (
                    "./tests/unit-tests/project-references/UnitTests.XUnit/UnitTests.XUnit.csproj",
                    //"xunit",  "--no-build -noshadow"
                    new DotNetCoreTestSettings()
                    {
                        ResultsDirectory = reports,
                    }
                );
                XUnit2
                (
                    "./tests/unit-tests/project-references/UnitTests.XUnit/bin/**/UnitTests.*.dll",
                    new XUnit2Settings
                    {
                        Parallelism = ParallelismOption.All,
                        NoAppDomain = true,
                        ReportName = "XUnit.Results",
                        HtmlReport = true,
                        XmlReport = true,
                        NUnitReport = true,
                        OutputDirectory = reports,
                    }
                );
            }
            catch (System.Exception)
            {
                Error("mc++ XUnit tests have failed");
            }
            finally
            {
                ReportUnit(reports);
            }
            MoveFile("TestResult.xml", "./externals/results/unit-tests/TestResult.xml");
        }
    );

Task("unit-tests-mstest")
    .Does
    (
        () =>
        {
            MSBuild
            (
                "./tests/unit-tests/project-references/UnitTests.MSTest/UnitTests.MSTest.csproj",
                new MSBuildSettings
                {
                    Configuration = "Debug",
                }.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;MSTEST")
            );
            MSTest
            (
                "./tests/unit-tests/project-references/UnitTests.MSTest/bin/Debug/**/UnitTests.MSTest.dll",
                new MSTestSettings
                {
                    ResultsFile = "./externals/results/unit-tests/MSTest.txt",
                }
            );
            DotNetCoreTest
            (
                "./tests/unit-tests/project-references/UnitTests.MSTest/UnitTests.MSTest.csproj",
                //"xunit",  "--no-build -noshadow"
                new DotNetCoreTestSettings()
                {
                    ResultsDirectory = reports,
                }
            );

            return;
        }
    );
//---------------------------------------------------------------------------------------

