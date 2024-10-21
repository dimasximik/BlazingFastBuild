#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BFGBuildConfig))]
public class BuildConfigEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        BFGBuildConfig config = (BFGBuildConfig)target;

        if (GUILayout.Button("Browse Development Key Path"))
        {
            config.developmentKeyPath = EditorUtility.OpenFilePanel("Select Development Key", "", "");
        }

        if (GUILayout.Button("Browse Release Key Path"))
        {
            config.releaseKeyPath = EditorUtility.OpenFilePanel("Select Release Key", "", "");
        }

        if (GUILayout.Button("Browse Build Folder"))
        {
            config.buildFolder = EditorUtility.SaveFolderPanel("Select Build Folder", "", "");
        }


        if (GUI.changed)
        {
            EditorUtility.SetDirty(config);
        }
    }
}
#endif