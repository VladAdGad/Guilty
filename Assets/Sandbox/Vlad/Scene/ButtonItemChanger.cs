using UnityEngine;
using UnityEngine.UI;

public class ButtonItemChanger : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    private string _name;
    private string _description;
    private Sprite _sprite;

    private Text[] _texts;
    private Text _nameText;
    private Text _descriptionText;

    private void Awake() => GetComponent<Button>().onClick.AddListener(ChangeNameAndDescription);

    private void ChangeNameAndDescription()
    {
        _nameText.text = _name;
        _descriptionText.text = _description;
    }

    public void SetFields(string name, string description, Sprite icon)
    {
        _name = name;
        _description = description;
        _sprite = icon;
        SetComponents();
    }

    private void SetComponents()
    {
        _texts = _panel.GetComponentsInChildren<Text>();
        _nameText = _texts[0];
        _descriptionText = _texts[1];
        GetComponent<Image>().sprite = _sprite;
    }
}
