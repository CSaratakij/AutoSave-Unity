using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DeleteEditorPrefsEditorWindow : EditorWindow
{
    [MenuItem("Edit/Clear all editor prefs")]
    public static void DeleteEditorPrefs()
    {
        EditorPrefs.DeleteAll();
    }
}

