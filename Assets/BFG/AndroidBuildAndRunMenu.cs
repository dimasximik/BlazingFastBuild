#if UNITY_EDITOR
using UnityEditor;

public static class AndroidBuildAndRunMenu
{
    [MenuItem("BFG/BuildAndRun/Android APK Development Mono", false, 300)]
    public static void BuildAndRunAPKDevMono() => AndroidBuildProcessor.BuildAndRunAPK(BuildType.Development, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/BuildAndRun/Android APK Development IL2CPP", false, 300)]
    public static void BuildAndRunAPKDevIL2CPP() => AndroidBuildProcessor.BuildAndRunAPK(BuildType.Development, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/BuildAndRun/Android APK Release Mono", false, 300)]
    public static void BuildAndRunAPKReleaseMono() => AndroidBuildProcessor.BuildAndRunAPK(BuildType.Release, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/BuildAndRun/Android APK Release IL2CPP", false, 300)]
    public static void BuildAndRunAPKReleaseIL2CPP() => AndroidBuildProcessor.BuildAndRunAPK(BuildType.Release, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/BuildAndRun/Android AAB Development Mono", false, 400)]
    public static void BuildAndRunAABDevMono() => AndroidBuildProcessor.BuildAndRunAAB(BuildType.Development, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/BuildAndRun/Android AAB Development IL2CPP", false, 400)]
    public static void BuildAndRunAABDevIL2CPP() => AndroidBuildProcessor.BuildAndRunAAB(BuildType.Development, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/BuildAndRun/Android AAB Release Mono", false, 400)]
    public static void BuildAndRunAABReleaseMono() => AndroidBuildProcessor.BuildAndRunAAB(BuildType.Release, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/BuildAndRun/Android AAB Release IL2CPP", false, 400)]
    public static void BuildAndRunAABReleaseIL2CPP() => AndroidBuildProcessor.BuildAndRunAAB(BuildType.Release, ScriptingImplementation.IL2CPP);
}
#endif