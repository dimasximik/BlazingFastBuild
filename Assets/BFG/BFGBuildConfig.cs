using UnityEngine;

#if UNITY_EDITOR

[CreateAssetMenu(fileName = "BFGBuildConfig", menuName = "Build/BFGBuildConfig", order = 1)]
public class BFGBuildConfig : ScriptableObject
{
    [Header("Build folder")] public string buildFolder;

    public string releaseKeyPath;
    public string releaseKeyPassword;
    public string releaseKeyAlias;
    public string releaseKeyAliasPassword;

    [Header("Leave development field empty if you want use unity develop key")]
    public string developmentKeyPath;

    public string developmentKeyPassword;
    public string developmentKeyAlias;
    public string developmentKeyAliasPassword;

    [Header("Architecture for IL2CPP build (mono always ARMv7)")]
    public UnityEditor.AndroidArchitecture IL2CPPArchitecture;

    [Header(
        "It is recommended to enable this option for a release build, when enabled, no cache from previous build is used, build from scratch \n Without this option, the build may be faster, but you may get a crash or other errors")]
    public bool cleanBuild = true;
}
#endif