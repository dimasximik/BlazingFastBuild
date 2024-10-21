#if UNITY_EDITOR
using UnityEditor;

public static class AndroidBuildMenu
{
    [MenuItem("BFG/Build/Android APK Development Mono", false, 0)]
    public static void BuildAPKDevMono() => AndroidBuildProcessor.BuildAPK(BuildType.Development, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/Build/Android APK Development IL2CPP", false, 0)]
    public static void BuildAPKDevIL2CPP() => AndroidBuildProcessor.BuildAPK(BuildType.Development, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/Build/Android APK Release Mono", false, 0)]
    public static void BuildAPKReleaseMono() => AndroidBuildProcessor.BuildAPK(BuildType.Release, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/Build/Android APK Release IL2CPP", false, 0)]
    public static void BuildAPKReleaseIL2CPP() => AndroidBuildProcessor.BuildAPK(BuildType.Release, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/Build/Android AAB Development Mono", false, 100)]
    public static void BuildAABDevMono() => AndroidBuildProcessor.BuildAAB(BuildType.Development, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/Build/Android AAB Development IL2CPP", false, 100)]
    public static void BuildAABDevIL2CPP() => AndroidBuildProcessor.BuildAAB(BuildType.Development, ScriptingImplementation.IL2CPP);

    [MenuItem("BFG/Build/Android AAB Release Mono", false, 100)]
    public static void BuildAABReleaseMono() => AndroidBuildProcessor.BuildAAB(BuildType.Release, ScriptingImplementation.Mono2x);

    [MenuItem("BFG/Build/Android AAB Release IL2CPP", false, 100)]
    public static void BuildAABReleaseIL2CPP() => AndroidBuildProcessor.BuildAAB(BuildType.Release, ScriptingImplementation.IL2CPP);
}
#endif