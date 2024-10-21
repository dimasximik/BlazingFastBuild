#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Linq;

public static class BuildUtils
{
    public static BFGBuildConfig GetConfig()
    {
        string guid = AssetDatabase.FindAssets("BFGBuildConfig").FirstOrDefault();
        if (guid == null)
        {
            Debug.LogError("BFGBuildConfig not found in project.");
            return null;
        }
        var path = AssetDatabase.GUIDToAssetPath(guid);
        return AssetDatabase.LoadAssetAtPath<BFGBuildConfig>(path);
    }

    public static string[] GetEnabledScenePaths()
    {
        return EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();
    }

    public static BuildOptions GetBuildOptions(BuildType buildType, bool isRun, bool cleanBuild)
    {
        var options = BuildOptions.None;

        if (buildType == BuildType.Development)
        {
            options |= BuildOptions.Development | BuildOptions.AllowDebugging;
            if (cleanBuild) options |= BuildOptions.CleanBuildCache;
        }
        else if (buildType == BuildType.Release && cleanBuild)
        {
            options |= BuildOptions.CleanBuildCache;
        }

        if (isRun) options |= BuildOptions.AutoRunPlayer;

        return options;
    }
}

public enum BuildType
{
    Development,
    Release
}
#endif