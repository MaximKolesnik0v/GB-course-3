using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using System;

public class TransitionScript : MonoBehaviour
{
    private PostProcessVolume _postProcessVolume;

    private ColorGrading _colorGrading;

    private float _default = 100;
    private float _b = -30f;
    private float _r = 150f;

    private void Start()
    {
        SettingsColorGrading();
    }

    private void Update()
    {
        if (_r < _default)
            _colorGrading.redCurve.value = _r++;


    }

    private void SettingsColorGrading()
    {
        _colorGrading = ScriptableObject.CreateInstance<ColorGrading>();
        _colorGrading.enabled.Override(true);
        _colorGrading.redCurve.Override(1);
    }
}
