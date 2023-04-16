using UnityEngine;
using UnityEngine.UI;

public class PlayerItem: MonoBehaviour
{
    [SerializeField] private RawImage avatar;
    [SerializeField] private Text nameField;
    [SerializeField] private Text scoreField;

    public void Init(string name, int score)
    {
        nameField.text = name;
        scoreField.text = score.ToString();
    }

    public void SetAvatar(Texture2D image) => avatar.texture = image;
}