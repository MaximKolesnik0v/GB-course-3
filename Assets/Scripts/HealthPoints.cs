using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private Texture2D _IconHp;
    [SerializeField] private float _hp = 100;

    private void OnGUI()
    {
        GUI.Box(new Rect(250, 880, 100, 100), $"{_hp}");
        GUI.Label(new Rect(150, 880, 100, 100), _IconHp);
    }
}
