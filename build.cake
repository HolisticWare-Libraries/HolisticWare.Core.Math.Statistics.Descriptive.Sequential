/*
#########################################################################################
Installing

    Windows - powershell
        
        Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        .\build.ps1

    Windows - cmd.exe prompt	
    
        powershell ^
            Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        powershell ^
            .\build.ps1
    
    Mac OSX 

        rm -fr tools/; mkdir ./tools/ ; \
        cp cake.packages.config ./tools/packages.config ; \
        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/osx ; \
        chmod +x ./build.sh ;
        ./build.sh

    Linux

        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/linux
        chmod +x ./build.sh && ./build.sh

Running Cake to Build targets

    Windows

        tools\Cake\Cake.exe --verbosity=diagnostic --target=libs
        tools\Cake\Cake.exe --verbosity=diagnostic --target=nuget
        tools\Cake\Cake.exe --verbosity=diagnostic --target=samples

        
    Mac OSX 
    
        mono tools/Cake/Cake.exe --verbosity=diagnostic --target=libs
        mono tools/Cake/Cake.exe --verbosity=diagnostic --target=nuget

        mono tools/nunit.consolerunner/NUnit.ConsoleRunner/tools/nunit3-console.exe \




#########################################################################################
*/
#addin nuget:?package=Cake.XCode
#addin nuget:?package=Cake.Xamarin.Build
#addin nuget:?package=Cake.Xamarin
#addin nuget:?package=Cake.FileHelpers


//---------------------------------------------------------------------------------------
// unit testing
#tool nuget:?package=NUnit.ConsoleRunner&version=3.8.0
//#tool nuget:?package=NUnit.Console&version=3.8.0&include=../Nunit.ConsoleRunner/**/*
//#tool nuget:?package=NUnit.Runners&version=3.8.0
#tool "nuget:?package=xunit.runner.console"
//---------------------------------------------------------------------------------------
// coverage
#tool "nuget:?package=OpenCover"
// dotCover is commercial
// #tool "nuget:?package=JetBrains.dotCover.CommandLineTools"
//---------------------------------------------------------------------------------------
// reporting
#tool "nuget:?package=ReportUnit"
#tool "nuget:?package=ReportGenerator"
//---------------------------------------------------------------------------------------

var TARGET = Argument ("t", Argument ("target", "Default"));


BuildSpec buildSpec = new BuildSpec () 
{
    Libs = new ISolutionBuilder [] 
    {
        new DefaultSolutionBuilder 
        {
            SolutionPath = "./source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.Source.sln",
            OutputFiles = new [] 
            { 
                new OutputFileCopy 
                { 
                    FromFile = "./source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Release/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll",
                    ToDirectory = "output/netstandard1.0/",
                },
                new OutputFileCopy 
                { 
                    FromFile = "./source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard13/bin/Release/netstandard1.3/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll",
                    ToDirectory = "output/netstandard1.3/",
                },
            }
        },
    },

    Samples = new ISolutionBuilder [] 
    {
        new DefaultSolutionBuilder 
        { 
            SolutionPath = "./samples/Samples.sln" 
        },	
    },

    Components = new []
    {
        new Component 
        { 
            ManifestDirectory = "./component" 
        },
    },

    NuGets = new [] 
    {
        new NuGetInfo 
        { 
            NuSpec = "./nuget/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.nuspec" 
        },
        new NuGetInfo 
        { 
            NuSpec = "./nuget/HolisticWare.Core.Math.Statistics.Descriptive.MatlabOctave.Sequential.nuspec" 
        },
        new NuGetInfo 
        { 
            NuSpec = "./nuget/HolisticWare.Core.Math.Statistics.Descriptive.Python.Sequential.nuspec" 
        },
        new NuGetInfo 
        { 
            NuSpec = "./nuget/HolisticWare.Core.Math.Statistics.Descriptive.R.Sequential.nuspec" 
        },
    },
};

Task("unit-tests")
    .IsDependentOn ("unit-tests-nunit")	
    .IsDependentOn ("unit-tests-xunit")
    .IsDependentOn ("unit-tests-mstest")
    .Does
    (
        () =>
        {
        }
    );

Task("unit-tests-nunit")
    .IsDependentOn ("externals-build")	
    .IsDependentOn ("libs")
    .IsDependentOn ("nuget")
    .Does
    (
        () =>
        {
            MSBuild
            (
                "./tests/unit-tests/UnitTests.NUnit/UnitTests.NUnit.csproj", 
                new MSBuildSettings 
                {
                    Configuration = "Debug",
                }.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
            );
            NUnit3
            (
                "./tests/unit-tests/UnitTests.NUnit/bin/Debug/**/UnitTests.NUnit.dll", 
                new NUnit3Settings 
                {
                }
            );
 
            return;
        }
    );

Task("unit-tests-xunit")
    .IsDependentOn ("externals-build")	
    .IsDependentOn ("libs")
    .IsDependentOn ("nuget")
    .Does
    (
        () =>
        {
            try
            {
                MSBuild
                (
                    "./tests/unit-tests/UnitTests.XUnit/UnitTests.XUnit.csproj", 
                    new MSBuildSettings 
                    {
                        Configuration = "Debug",
                    }.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;XUNIT")
                );
                DotNetCoreTest
                (
                    "./tests/unit-tests/UnitTests.XUnit/UnitTests.XUnit.csproj",
                    //"xunit",  "--no-build -noshadow"
                    new DotNetCoreTestSettings()
                    {
                    }
                );
                XUnit2
                (
                    "./tests/unit-tests/UnitTests.XUnit/bin/**/UnitTests.*.dll",
                    new XUnit2Settings 
                    {
                        Parallelism = ParallelismOption.All,
                        HtmlReport = false,
                        NoAppDomain = true,
                        XmlReport = true,
                        OutputDirectory = "./build"
                    }
                );
                
            }
            catch (System.Exception)
            {  
                Error("mc++ XUnit tests failed");   
            }

            ReportUnit
                (
                    "./externals/unit-tests-xunit-report.xml", 
                    "./externals/unit-tests-xunit-report.html"
                );
        }
    );

Task("unit-tests-mstest")
    .IsDependentOn ("externals-build")	
    .IsDependentOn ("libs")
    .IsDependentOn ("nuget")
    .Does
    (
        () =>
        {
            MSBuild
            (
                "./tests/unit-tests/UnitTests.MSTest/UnitTests.MSTest.csproj", 
                new MSBuildSettings 
                {
                    Configuration = "Debug",
                }.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;MSTEST")
            );
            MSTest
            (
                "./tests/unit-tests/UnitTests.MSTest/bin/Debug/**/UnitTests.MSTest.dll", 
                new MSTestSettings 
                {
                }
            );
            DotNetCoreTest
            (
                "./tests/unit-tests/UnitTests.MSTest/UnitTests.MSTest.csproj",
                //"xunit",  "--no-build -noshadow"
                new DotNetCoreTestSettings()
                {
                }
            );
 
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
                                -output:/externals/coverage-opencover-xunit-report.xml
                                -searchdirs:./tests/unit-tests/UnitTests.XUnit/UnitTests.*/**/UnitTests.*.dll
                                "
                            }
                        );


            // OpenCover
            //     (
            //         tool => 
            //         {
            //             tool.XUnit2
            //             (
            //                 "./tests/unit-tests/UnitTests.XUnit/UnitTests.*/**/UnitTests.*.dll",
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




Task ("externals")
    .IsDependentOn ("externals-base")
    // .WithCriteria (!FileExists ("./externals/HolisticWare.Core.Math.Statistics.aar"))
    .Does 
    (
        () => 
        {
            Information("externals ...");

            if (!DirectoryExists ("./externals/"))
            {
                CreateDirectory ("./externals");
            }

            Information("    downloading ...");

            // if ( ! string.IsNullOrEmpty(AAR_URL) )
            // {
            // 	//DownloadFile (AAR_URL, "./externals/HolisticWare.Core.Math.Statistics.aar");
            // }
        }
    );

Task("externals-build")
    .IsDependentOn ("nuget-restore")	
    .Does
    (
        () => 
        {
            FilePathCollection files = GetFiles("./external/**/build.cake");
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

Task ("clean")
    .IsDependentOn ("clean-base")
    .Does
    (
        () => 
        {
            if (DirectoryExists ("./externals/"))
            {
                DeleteDirectory ("./externals", true);
            }
        }
    );

SetupXamarinBuildTasks (buildSpec, Tasks, Task);

RunTarget (TARGET);

if(! IsRunningOnWindows())
{
    try
    {
        int exit_code = StartProcess
                                (
                                    "tree", 
                                    new ProcessSettings
                                    { 
                                        Arguments = @"./output"
                                    }
                                );
    }
    catch(Exception ex)
    {
        Information($"unable to start process - tree {ex.Message}");
    }
}
else
{
    // int exit_code = StartProcess
    //                         (
    //                             "dir", 
    //                             new ProcessSettings
    //                             { 
    //                                 Arguments = @"output"
    //                             }
    //                         );
    
}

