using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AdjustSizeOfFoot : MonoBehaviour
{
    public Transform leftToEBase, rightToEBase, leftToe, rightToe, leftupLegInstepOne, rightupLegInstepOne, leftFootInstepTwo, rightFootInstepTwo; //Parts of Legs

    //Sizes of Foot Length, Toes and Ball
    private float leftFootLengthX, leftFootLengthY, leftFootLengthZ;
    private float rightFootLengthX, rightFootLengthY, rightFootLengthZ;

    //Sizes of Instep
    private float leftUpX, leftUpY, rightUpX, rightUpY;
    private float leftFootY, rightFootY;

    void Start()
    {
        resetLength();
    }

    void Update()
    {
        SetFootLength();
        ChangeFootLength();

        if (FootSelection.resetSelect)
        {
            resetLength();
            FootSelection.resetSelect = false;
        }
    }

    private void SetFootLength()
    {
        if (String.Equals(DropDown.dropDownTag, "Toes_Girth"))
        {
            switch (DropDown.dropDownValue)
            {
                case -10:
                    ScaleZ(-1);
                    break;
                case -9:
                    ScaleZ(-0.8F);
                    break;
                case -8:
                    ScaleZ(-0.6F);
                    break;
                case -7:
                    ScaleZ(-0.4F);
                    break;
                case -6:
                    ScaleZ(-0.2F);
                    break;
                case -5:
                    ScaleZ(0);
                    break;
                case -4:
                    ScaleZ(0.2F);
                    break;
                case -3:
                    ScaleZ(0.4F);
                    break;
                case -2:
                    ScaleZ(0.6F);
                    break;
                case -1:
                    ScaleZ(0.8F);
                    break;
                case 0:
                    ScaleZ(1);
                    break;
                case 1:
                    ScaleZ(1.5F);
                    break;
                case 2:
                    ScaleZ(2);
                    break;
                case 3:
                    ScaleZ(2.5F);
                    break;
                case 4:
                    ScaleZ(3);
                    break;
                case 5:
                    ScaleZ(3.5F);
                    break;
                case 6:
                    ScaleZ(4);
                    break;
                case 7:
                    ScaleZ(4.5F);
                    break;
                case 8:
                    ScaleZ(5);
                    break;
                case 9:
                    ScaleZ(5.5F);
                    break;
                case 10:
                    ScaleZ(6);
                    break;
                default:
                    ScaleZ(1);
                    break;
            }
        }
        else if (String.Equals(DropDown.dropDownTag, "Instep_Height"))
        {
            switch (DropDown.dropDownValue)
            {
                case -10:
                    ScaleNext(1, 1.08F, 0.5F);
                    break;
                case -9:
                    ScaleNext(1, 1.072F, 0.55F);
                    break;
                case -8:
                    ScaleNext(1, 1.064F, 0.6F);
                    break;
                case -7:
                    ScaleNext(1, 1.056F, 0.65F);
                    break;
                case -6:
                    ScaleNext(1, 1.048F, 0.7F);
                    break;
                case -5:
                    ScaleNext(1, 1.04F, 0.75F);
                    break;
                case -4:
                    ScaleNext(1, 1.032F, 0.8F);
                    break;
                case -3:
                    ScaleNext(1, 1.024F, 0.85F);
                    break;
                case -2:
                    ScaleNext(1, 1.016F, 0.9F);
                    break;
                case -1:
                    ScaleNext(1, 1.008F, 0.95F);
                    break;
                case 0:
                    ScaleNext(1, 1, 1);
                    break;
                case 1:
                    ScaleNext(0.98F, 0.988F, 1.1F);
                    break;
                case 2:
                    ScaleNext(0.96F, 0.976F, 1.2F);
                    break;
                case 3:
                    ScaleNext(0.94F, 0.964F, 1.3F);
                    break;
                case 4:
                    ScaleNext(0.92F, 0.952F, 1.4F);
                    break;
                case 5:
                    ScaleNext(0.9F, 0.94F, 1.5F);
                    break;
                case 6:
                    ScaleNext(0.88F, 0.928F, 1.6F);
                    break;
                case 7:
                    ScaleNext(0.86F, 0.916F, 1.7F);
                    break;
                case 8:
                    ScaleNext(0.84F, 0.904F, 1.8F);
                    break;
                case 9:
                    ScaleNext(0.82F, 0.892F, 1.9F);
                    break;
                case 10:
                    ScaleNext(0.8F, 0.88F, 2);
                    break;
                default:
                    ScaleNext(1, 1, 1);
                    break;
            }
        }
        else if (String.Equals(DropDown.dropDownTag, "Foot_Length") || String.Equals(DropDown.dropDownTag, "Ball_Girth") || String.Equals(DropDown.dropDownTag, "Ball_Width"))
        {
            switch (DropDown.dropDownValue)
            {
                case -10:
                    ScaleZ(0.5F);
                    break;
                case -9:
                    ScaleZ(0.55F);
                    break;
                case -8:
                    ScaleZ(0.6F);
                    break;
                case -7:
                    ScaleZ(0.65F);
                    break;
                case -6:
                    ScaleZ(0.7F);
                    break;
                case -5:
                    ScaleZ(0.75F);
                    break;
                case -4:
                    ScaleZ(0.8F);
                    break;
                case -3:
                    ScaleZ(0.85F);
                    break;
                case -2:
                    ScaleZ(0.9F);
                    break;
                case -1:
                    ScaleZ(0.95F);
                    break;
                case 0:
                    ScaleZ(1);
                    break;
                case 1:
                    ScaleZ(1.1F);
                    break;
                case 2:
                    ScaleZ(1.2F);
                    break;
                case 3:
                    ScaleZ(1.3F);
                    break;
                case 4:
                    ScaleZ(1.4F);
                    break;
                case 5:
                    ScaleZ(1.5F);
                    break;
                case 6:
                    ScaleZ(1.6F);
                    break;
                case 7:
                    ScaleZ(1.7F);
                    break;
                case 8:
                    ScaleZ(1.8F);
                    break;
                case 9:
                    ScaleZ(1.9F);
                    break;
                case 10:
                    ScaleZ(2);
                    break;
                default:
                    ScaleZ(1);
                    break;
            }
        } 
    }

    private void ChangeFootLength()
    {
        if (String.Equals(DropDown.dropDownTag, "Foot_Length") || String.Equals(DropDown.dropDownTag, "Ball_Girth") || String.Equals(DropDown.dropDownTag, "Ball_Width"))
        {
            FootBallSelect();
        }
        else if (String.Equals(DropDown.dropDownTag, "Toes_Girth"))
        {
            if (FootSelection.leftSelect)
            {
                leftToe.localScale = new Vector3(leftFootLengthX, leftFootLengthY, leftFootLengthZ);
            }
            else if (FootSelection.rightSelect)
            {
                rightToe.localScale = new Vector3(rightFootLengthX, rightFootLengthY, rightFootLengthZ);
            }
        }
        else if (String.Equals(DropDown.dropDownTag, "Instep_Height"))
        {
            if (FootSelection.leftSelect)
            {
                leftupLegInstepOne.localScale = new Vector3(leftUpX, leftUpY, leftFootLengthZ);
                leftFootInstepTwo.localScale = new Vector3(leftFootLengthX, leftFootY, leftFootLengthZ);
            }
            else if (FootSelection.rightSelect)
            {
                rightupLegInstepOne.localScale = new Vector3(rightUpX, rightUpY, rightFootLengthZ);
                rightFootInstepTwo.localScale = new Vector3(rightFootLengthX, rightFootY, rightFootLengthZ);
            }
        }
    }

    private void ScaleZ(float zScale)
    {
        if (String.Equals(DropDown.dropDownTag, "Foot_Length"))
        {
            leftFootLengthZ = zScale;
            rightFootLengthZ = zScale;
        }
        else if(String.Equals(DropDown.dropDownTag, "Toes_Girth") || String.Equals(DropDown.dropDownTag, "Ball_Girth"))
        {
            leftFootLengthX = zScale;
            leftFootLengthY = zScale;

            rightFootLengthX = zScale;
            rightFootLengthY = zScale;
        }
        else if (String.Equals(DropDown.dropDownTag, "Ball_Width"))
        {
            leftFootLengthX = zScale;
            rightFootLengthX = zScale;
        }
        else if (String.Equals(DropDown.dropDownTag, "Instep_Height"))
        {
            leftFootLengthX = zScale;
            rightFootLengthX = zScale;
        }
    }

    private void ScaleNext(float upLegX, float upLegY, float footY)
    {
        leftUpX = upLegX;
        rightUpX = upLegX;

        leftUpY = upLegY;
        rightUpY = upLegY;

        leftFootY = footY;
        rightFootY = footY;
    }

    private void FootBallSelect()
    {
        if (FootSelection.leftSelect)
        {
            leftToEBase.localScale = new Vector3(leftFootLengthX, leftFootLengthY, leftFootLengthZ);
        }
        else if (FootSelection.rightSelect)
        {
            rightToEBase.localScale = new Vector3(rightFootLengthX, rightFootLengthY, rightFootLengthZ);
        }
    }

    private void resetLength()
    {
        leftFootLengthX = 1;
        leftFootLengthY = 1;
        leftFootLengthZ = 1;

        rightFootLengthX = 1;
        rightFootLengthY = 1;
        rightFootLengthZ = 1;

        leftUpX = 1;
        leftUpY = 1;
        rightUpX = 1;
        rightUpY = 1;

        leftFootY = 1;
        rightFootY = 1;

        leftToEBase.localScale = new Vector3(1, 1, 1);
        rightToEBase.localScale = new Vector3(1, 1, 1);

        leftToe.localScale = new Vector3(1, 1, 1);
        rightToe.localScale = new Vector3(1, 1, 1);

        leftupLegInstepOne.localScale = new Vector3(1, 1, 1);
        rightupLegInstepOne.localScale = new Vector3(1, 1, 1);

        leftFootInstepTwo.localScale = new Vector3(1, 1, 1);
        rightFootInstepTwo.localScale = new Vector3(1, 1, 1);
    }
}
