// load up common tools
#tool nuget:https://www.myget.org/F/subpointsolutions-staging/api/v2?package=SubPointSolutions.CakeBuildTools&prerelease
#load tools\SubPointSolutions.CakeBuildTools\scripts\SubPointSolutions.CakeBuild.Core.cake

// redefining default build task
// cleaning up existing actions, adding our custom one

// in that case we follow all the avialable 'Default' build profiles from the core build script

defaultActionBuild.Task.Actions.Clear();
defaultActionBuild
    .Does(() => 
{
    Information(string.Format("Building VSIX for solution:[{0}]", defaultSolutionFilePath));

	// https://blog.agchapman.com/vsix-continuous-integration-using-cake-and-appveyor/
	MSBuild(defaultSolutionFilePath, settings =>
        settings.SetPlatformTarget(PlatformTarget.MSIL)
            .SetMSBuildPlatform(MSBuildPlatform.x86)
            .UseToolVersion(MSBuildToolVersion.VS2013)
            //.WithProperty("TreatWarningsAsErrors","false")
            //.SetVerbosity(Verbosity.Quiet)
            .WithTarget("Build")
            .SetConfiguration("Debug"));

	/*
	MSBuild(defaultSolutionFilePath, settings => {

        //settings.Verbosity = Verbosity.Quiet; 
        
        // Building with MSBuild 12.0 fails #97
        // CRAZY!! to avoid the following error
        // error MSB4018: The "ValidateVsixManifest" task failed unexpectedly
        settings.ToolPath = @"C:\Program Files (x86)\MSBuild\12.0\bin\MSBuild.exe";
    });
	*/
});

// filling up default build task with custom build
//defaultActionBuild.Does(actionCustomBuild);

// default targets
RunTarget(target);