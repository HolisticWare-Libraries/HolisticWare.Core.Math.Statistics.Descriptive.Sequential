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

FilePathCollection LibSourceSolutions = GetFiles($"./source/**/*.sln");
FilePathCollection LibSourceProjects = GetFiles($"./source/**/*.csproj");


Task("libs")
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
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
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
                    new DotNetCoreBuildSettings
                    {
                        Configuration = "Debug",
                    }
                    //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                );
                DotNetCoreBuild
                (
                    sln.ToString(),
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
            FilePathCollection LibSourceProjects = GetFiles($"./source/**/*.csproj");

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

Task("nuget")
    .Does
    (
        () =>
        {
            return;
        }
    );


// FilePathCollection UnitTestsNUnitMobileProjects = GetFiles($"./tests/unit-tests/**/*.NUnit.Xamarin*.csproj");
// FilePathCollection UnitTestsXUnitProjects = GetFiles($"./tests/unit-tests/**/*.XUnit.csproj");
// FilePathCollection UnitTestsMSTestProjects = GetFiles($"./tests/unit-tests/**/*.NUnit.csproj");

Task("unit-tests")
    .IsDependentOn ("unit-tests-nunit")	
    .IsDependentOn ("unit-tests-xunit")
    .IsDependentOn ("unit-tests-mstest")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task("unit-tests-nunit")
    .Does
    (
        () =>
        {
            FilePathCollection UnitTestsNUnitAssemblies;
            FilePathCollection UnitTestsNUnitProjects = GetFiles($"./tests/unit-tests/**/*.NUnit.csproj");

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
  
            UnitTestsNUnitAssemblies = GetFiles($"./tests/unit-tests/**/bin/Debug/*.NUnit.dll");

            foreach(FilePath asm in UnitTestsNUnitAssemblies)
            {
                Information($"testing ................ {asm}");
            }

            NUnit3
            (
                UnitTestsNUnitAssemblies, 
                new NUnit3Settings 
                {
                }
            );

            UnitTestsNUnitAssemblies = GetFiles($"./tests/unit-tests/**/bin/Release/*.NUnit.dll");

            foreach(FilePath asm in UnitTestsNUnitAssemblies)
            {
                Information($"testing ................ {asm}");
            }

            NUnit3
            (
                UnitTestsNUnitAssemblies, 
                new NUnit3Settings 
                {
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
    //.IsDependentOn ("externals-base")
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
    .Does
    (
        () => 
        {
            if (DirectoryExists ("./externals/"))
            {
                DeleteDirectory ("./externals", true);
            }

            return;
        }
    );

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

