#if UNITY_EDITOR
using UnityEditor;

public static class iOSBuildMenu
{
    [MenuItem("BFG/Build/iOS Development", false, 600)]
    public static void BuildIOSDevelopment() => iOSBuildProcessor.BuildIOS(BuildType.Development);

    [MenuItem("BFG/Build/iOS Release", false, 600)]
    public static void BuildIOSRelease() => iOSBuildProcessor.BuildIOS(BuildType.Release);
}
#endif