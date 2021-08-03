using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class EffectSettings : MonoBehaviour
{
    [SerializeField] private Button _first;
    [SerializeField] private Button _second;
    [SerializeField] private PostProcessProfile _firstProfile;
    [SerializeField] private PostProcessProfile _secondProfile;
    [SerializeField] private PostProcessVolume _postProcessVolume;

    private void Start()
    {
        _first.onClick.AddListener(() => ChangeSettings(true));
        _second.onClick.AddListener(() => ChangeSettings(false));
    }

    private void OnDestroy()
    {
        _first.onClick.RemoveAllListeners();
        _second.onClick.RemoveAllListeners();
    }

    private void ChangeSettings(bool isFirstProcess)
    {
        _postProcessVolume.profile = isFirstProcess ? _firstProfile : _secondProfile;
    }
}
