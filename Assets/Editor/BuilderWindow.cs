using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuilderWindow : EditorWindow {

    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    // Add menu named "My Window" to the Window menu
    [MenuItem("Build/Builder Window")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        BuilderWindow window = (BuilderWindow)EditorWindow.GetWindow(typeof(BuilderWindow));
        window.Show();
    }

    //GET DATA
    void FetchData()
    {
        // GET from config.json     
    }

    void SyncData()
    {

        // SEND to UNITY Settings

        // SAVE to config.json
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Package Name", myString);

        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("App Name", myString);

        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("App Version", myString);

        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Build Number", myString);


        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}
