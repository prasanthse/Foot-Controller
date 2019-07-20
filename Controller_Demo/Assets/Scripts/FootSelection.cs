using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FootSelection : MonoBehaviour
{
    public Button left, right, reset;
    public static bool leftSelect, rightSelect, resetSelect;
    public static string footTag;

    void Start()
    {
        leftSelect = false;
        rightSelect = false;
        resetSelect = false;

        left.onClick.AddListener(ActivateLeft);
        right.onClick.AddListener(ActivateRight);
        reset.onClick.AddListener(ActivateReset);
    }

    private void ActivateLeft()
    {
        leftSelect = true;
        rightSelect = false;

        ChangeColors(Color.yellow, Color.white, Color.white);
    }

    private void ActivateRight()
    {
        rightSelect = true;
        leftSelect = false;

        ChangeColors(Color.white, Color.yellow, Color.white);
    }

    private void ActivateReset()
    {
        rightSelect = false;
        leftSelect = false;

        resetSelect = true;

        ChangeColors(Color.white, Color.white, Color.white);
    }

    private void ChangeColors(Color leftColor, Color rightColor, Color bothColor)
    {
        left.GetComponent<Image>().color = leftColor;
        right.GetComponent<Image>().color = rightColor;
        reset.GetComponent<Image>().color = bothColor;
    }
}
