#if UNITY_EDITOR
using UnityEditor;

public static class iOSBuildAndRunMenu
{
    [MenuItem("BFG/BuildAndRun/iOS Development", false, 600)]
    public static void BuildAndRunIOSDevelopment() => iOSBuildProcessor.BuildAndRunIOS(BuildType.Development);

    [MenuItem("BFG/BuildAndRun/iOS Release", false, 600)]
    public static void BuildAndRunIOSRelease() => iOSBuildProcessor.BuildAndRunIOS(BuildType.Release);
}
#endif