#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

public static class AndroidBuildProcessor
{
    public static void BuildAPK(BuildType buildType, ScriptingImplementation scriptingBackend)
    {
        BuildAndroid(buildType, scriptingBackend, false, false);
    }

    public static void BuildAndRunAPK(BuildType buildType, ScriptingImplementation scriptingBackend)
    {
        BuildAndroid(buildType, scriptingBackend, true, false);
    }

    public static void BuildAAB(BuildType buildType, ScriptingImplementation scriptingBackend)
    {
        BuildAndroid(buildType, scriptingBackend, false, true);
    }

    public static void BuildAndRunAAB(BuildType buildType, ScriptingImplementation scriptingBackend)
    {
        BuildAndroid(buildType, scriptingBackend, true, true);
    }

    private static void BuildAndroid(BuildType buildType, ScriptingImplementation scriptingBackend, bool isRun, bool isAAB)
    {
        var config = BuildUtils.GetConfig();
        if (config == null) return;

        SetAndroidKeystore(buildType, config);

        SetAndroidArchitecture(scriptingBackend, config);

        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, scriptingBackend);
        EditorUserBuildSettings.buildAppBundle = isAAB;

        string extension = isAAB ? "aab" : "apk";
        string locationPath = $"{config.buildFolder}/Android/{buildType}_{scriptingBackend}.{extension}";

        var options = BuildUtils.GetBuildOptions(buildType, isRun, config.cleanBuild);

        BuildPipeline.BuildPlayer(BuildUtils.GetEnabledScenePaths(), locationPath, BuildTarget.Android, options);
        Debug.Log($"Build complete: {locationPath}");
    }

    private static void SetAndroidKeystore(BuildType buildType, BFGBuildConfig config)
    {
        if (buildType == BuildType.Release)
        {
            if (!string.IsNullOrEmpty(config.releaseKeyPath) && File.Exists(config.releaseKeyPath))
            {
                Debug.Log("Using custom release keystore for signing.");
                PlayerSettings.Android.useCustomKeystore = true;
                PlayerSettings.Android.keystoreName = config.releaseKeyPath;
                PlayerSettings.Android.keystorePass = config.releaseKeyPassword;
                PlayerSettings.Android.keyaliasName = config.releaseKeyAlias;
                PlayerSettings.Android.keyaliasPass = config.releaseKeyAliasPassword;
            }
            else
            {
                Debug.LogWarning("Release keystore not found or not specified, using default Unity keystore.");
                PlayerSettings.Android.useCustomKeystore = false;
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(config.developmentKeyPath) && File.Exists(config.developmentKeyPath))
            {
                Debug.Log("Using custom development keystore for signing.");
                PlayerSettings.Android.useCustomKeystore = true;
                PlayerSettings.Android.keystoreName = config.developmentKeyPath;
                PlayerSettings.Android.keystorePass = config.developmentKeyPassword;
                PlayerSettings.Android.keyaliasName = config.developmentKeyAlias;
                PlayerSettings.Android.keyaliasPass = config.developmentKeyAliasPassword;
            }
            else
            {
                Debug.LogWarning("Development keystore not found, using Unity default keystore.");
                PlayerSettings.Android.useCustomKeystore = false;
            }
        }
    }

    private static void SetAndroidArchitecture(ScriptingImplementation scriptingBackend, BFGBuildConfig config)
    {
        if (scriptingBackend == ScriptingImplementation.Mono2x)
        {
            PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARMv7;
        }
        else
        {
            PlayerSettings.Android.targetArchitectures = config.IL2CPPArchitecture;
        }
    }
}
#endif
