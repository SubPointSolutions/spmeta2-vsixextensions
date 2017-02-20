﻿// load up common tools
#load SubPointSolutions.CakeBuild.Core.cake

// redefining default build task
// cleaning up existing actions, adding our custom one

// in that case we follow all the avialable 'Default' build profiles from the core build script

defaultActionBuild.Task.Actions.Clear();
defaultActionBuild
    .Does(() => 
{
    Information(string.Format("Building VSIX for solution:[{0}]", defaultSolutionFilePath));

	MSBuild(defaultSolutionFilePath, settings => {

        settings.Verbosity = Verbosity.Quiet; 
        
        // Building with MSBuild 12.0 fails #97
        // CRAZY!! to avoid the following error
        // error MSB4018: The "ValidateVsixManifest" task failed unexpectedly
        settings.ToolPath = @"C:\Program Files (x86)\MSBuild\12.0\bin\MSBuild.exe";
    });
});

// filling up default build task with custom build
//defaultActionBuild.Does(actionCustomBuild);

// default targets
RunTarget(target);