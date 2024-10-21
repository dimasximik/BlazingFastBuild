#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public static class iOSBuildProcessor
{
    private const string BuildFolder = "Builds/iOS";

    public static void BuildIOS(BuildType buildType)
    {
        BuildIOS(buildType, false);
    }

    public static void BuildAndRunIOS(BuildType buildType)
    {
        BuildIOS(buildType, true);
    }

    private static void BuildIOS(BuildType buildType, bool isRun)
    {
        var config = BuildUtils.GetConfig();
        if (config == null) return;

        PlayerSettings.SetScriptingBackend(BuildTargetGroup.iOS, ScriptingImplementation.IL2CPP);

        string locationPath = $"{BuildFolder}/{buildType}_IL2CPP";
        var options = BuildUtils.GetBuildOptions(buildType, isRun, config.cleanBuild);

        BuildPipeline.BuildPlayer(BuildUtils.GetEnabledScenePaths(), locationPath, BuildTarget.iOS, options);
        Debug.Log($"Build complete: {locationPath}");
    }
}
#endif