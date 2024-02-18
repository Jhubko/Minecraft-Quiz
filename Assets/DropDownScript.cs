using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownScript : MonoBehaviour
{
    public GameObject thirdPlayerTextBox;
    public GameObject fourthPlayerTextBox;
    public TMP_Dropdown dropDown;


    private void Start()
    {
        dropDown.onValueChanged.AddListener(delegate
        {
            AddPlayerTextBox(dropDown);
        });
        
    }

    public void AddPlayerTextBox(TMP_Dropdown sender)
    {
        switch (dropDown.options[dropDown.value].text)
        {
            case "2":
                thirdPlayerTextBox.SetActive(false);
                fourthPlayerTextBox.SetActive(false);
                break;
            case "3":
                thirdPlayerTextBox.SetActive(true);
                fourthPlayerTextBox.SetActive(false);
                break;
            case "4":
                thirdPlayerTextBox.SetActive(true);
                fourthPlayerTextBox.SetActive(true);
                break;
        }
    }
}
