using System;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private Texture2D _IconHp;
    [SerializeField] private float _Hp = 100;

    float width = Screen.width;
    float height = Screen.height;


    private void OnGUI()
    {
        GUI.Box(new Rect(250, 880, 100, 100), $"{_Hp}");
        GUI.Label(new Rect(150, 880, 100, 100), _IconHp);
    }
}
