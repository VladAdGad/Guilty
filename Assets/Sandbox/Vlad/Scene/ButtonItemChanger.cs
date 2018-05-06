using UnityEngine;
using UnityEngine.UI;

public class ButtonItemChanger : MonoBehaviour
{
    public string name;
    public string description;

    private GameObject nameObject;
    private GameObject descriptionObject;

    private Text nameText;
    private Text descriptionText;

    private void Start()
    {
        nameObject = GameObject.Find("Name");
        descriptionObject = GameObject.Find("Description");
        nameText = nameObject.GetComponent<Text>();
        descriptionText = descriptionObject.GetComponent<Text>();
    }

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(SetNameAndDescription);
    }

    private void SetNameAndDescription()
    {
        nameText.text = name;
        descriptionText.text = description;
    }
}
