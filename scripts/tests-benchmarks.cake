//---------------------------------------------------------------------------------------
Task("bechmark-tests")
    .IsDependentOn ("bechmark-tests-nunit")
    .IsDependentOn ("bechmark-tests-xunit")
    .IsDependentOn ("bechmark-tests-mstest")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task ("bechmark-tests-nunit")
    .IsDependentOn ("unit-tests-nunit")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task ("bechmark-tests-xunit")
    .IsDependentOn ("unit-tests-xunit")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task ("bechmark-tests-mstest")
    .IsDependentOn ("unit-tests-mstest")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task ("coverage-xunit")
    .IsDependentOn ("unit-tests-xunit")
    .Does
    (
        () =>
        {
            int exit_code = StartProcess
                        (
                            "./tools/OpenCover.4.6.519/tools/OpenCover.Console.exe",
                            new ProcessSettings
                            {
                                Arguments =
                                @"
                                -target:
                                -output:./externals/coverage-opencover-xunit-report.xml
                                -searchdirs:./tests/unit-tests/project-references/UnitTests.XUnit/UnitTests.*/**/UnitTests.*.dll
                                "
                            }
                        );


            // OpenCover
            //     (
            //         tool =>
            //         {
            //             tool.XUnit2
            //             (
            //                 "./tests/unit-tests/project-references/UnitTests.XUnit/UnitTests.*/**/UnitTests.*.dll",
            //                 new XUnit2Settings
            //                 {
            //                     ShadowCopy = false
            //                 }
            //             );
            //         },
            //         new FilePath("./externals/coverage-opencover-xunit-report.xml"),
            //         new OpenCoverSettings()
            //             //.WithFilter("+[App]*")
            //             //.WithFilter("-[App.Tests]*")
            //     );



        }
    );
//---------------------------------------------------------------------------------------
