using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FindObjectsWithScript : EditorWindow
{
    [MenuItem("Tools/Find Objects With Script")]
    public static void ShowWindow()
    {
        GetWindow<FindObjectsWithScript>();
    }

    void OnGUI()
    {
        if (GUILayout.Button("Find Objects"))
        {
            FindObjects();
        }
    }

    private void FindObjects()
    {
        foreach (GameObject obj in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.GetComponent<TheScriptYouWannaFind>() != null)
            {
                Debug.Log(obj.name, obj);
            }
        }
    }

}
