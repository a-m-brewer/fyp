﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(MapGeneratorMain))]
public class MapEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapGeneratorMain myScript = (MapGeneratorMain)target;

        myScript.allTemplateRoomData = myScript.LoadMaps(myScript.mapDataText);

        if (GUILayout.Button("Generate Level"))
        {
            myScript.GenerateMap(new Vector2(24, 10));
        }
    }
}
