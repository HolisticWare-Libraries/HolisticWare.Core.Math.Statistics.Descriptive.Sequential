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
#tool nuget:?package=XamarinComponent
//#tool nuget:?package=NUnit.Runners
#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#tool nuget:?package=NUnit.Console&include=../Nunit.ConsoleRunner/**/*

#addin nuget:?package=Cake.XCode
#addin nuget:?package=Cake.Xamarin.Build
#addin nuget:?package=Cake.Xamarin
#addin nuget:?package=Cake.FileHelpers

var TARGET = Argument ("t", Argument ("target", "Default"));


BuildSpec buildSpec = new BuildSpec () 
{
    Libs = new ISolutionBuilder [] 
    {
        new DefaultSolutionBuilder 
        {
            SolutionPath = "./source/Source.sln",
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
        new DefaultSolutionBuilder 
        {
            SolutionPath = "tests/unit-tests/UnitTests.sln",
        }
    },

    Samples = new ISolutionBuilder [] 
    {
        new DefaultSolutionBuilder 
        { 
            SolutionPath = "./samples/.Samples.sln" 
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
    },
};

Task("unit-tests")
    .IsDependentOn ("externals-build")	
    .IsDependentOn ("nuget")
    .IsDependentOn ("libs")
    .Does
    (
        () =>
        {
            NUnit3
            (
                "./tests/unit-tests/**/bin/Release/**/*UnitTests*.dll", 
                new NUnit3Settings 
                {
                    NoResults = true
                }
            );
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
    int exit_code = StartProcess
                            (
                                "tree", 
                                new ProcessSettings
                                { 
                                    Arguments = @"./output"
                                }
                            );
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

