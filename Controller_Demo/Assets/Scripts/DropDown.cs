using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DropDown : MonoBehaviour
{
    private Dropdown dropdown;
    private const int numberOfSizes = 22;
    private List<string> dropOptions = new List<string> {"Select", "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    public static int dropDownValue;
    public static string dropDownTag;

    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.ClearOptions();
        dropdown.AddOptions(dropOptions);

        int.TryParse(dropOptions[11], out dropDownValue);
    }

    public void selectOptions()
    {
        string value = dropOptions[dropdown.value].ToString();
        
        if(String.Equals(value, "Select"))
        {
            Debug.Log("No changes");
        }
        else
        {
            int.TryParse(dropOptions[dropdown.value], out dropDownValue);
            getClickedDropDown();
        }
    }

    private void getClickedDropDown()
    {
        if (dropdown.CompareTag("Foot_Length"))
        {
            dropDownTag = "Foot_Length";
        }
        else if (dropdown.CompareTag("Toes_Girth"))
        {
            dropDownTag = "Toes_Girth";
        }
        else if (dropdown.CompareTag("Ball_Girth"))
        {
            dropDownTag = "Ball_Girth";
        }
        else if (dropdown.CompareTag("Ball_Width"))
        {
            dropDownTag = "Ball_Width";
        }
        else if (dropdown.CompareTag("Instep_Height"))
        {
            dropDownTag = "Instep_Height";
        }
    }
}
