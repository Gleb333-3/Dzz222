using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nen : MonoBehaviour
{
    private float hSliderValue = 2.0f;


    public GUIStyle Styl;
    public Texture2D icon;
    public Texture2D icon2;
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(40, 10, 260, 30), icon);
        GUI.DrawTexture(new Rect(10, 10, 30, 30), icon2);

        GUI.Label(new Rect(50, 15, 40, 20), text: "100%");
    }

}