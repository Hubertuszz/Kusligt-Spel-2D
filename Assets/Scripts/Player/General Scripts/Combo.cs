using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    
    public Score sc;
    public int comboLvl = 0;
    public Text comboTxt;

    public void NewCombo()
    {
        CancelInvoke("StopCombo");
        comboLvl++;
        comboTxt.enabled = true;
        comboTxt.text = "COMBO LEVEL " + comboLvl;
        Invoke("StopCombo", 4.0f);
    }

    void StopCombo()
    {
        comboLvl = 0;
        comboTxt.enabled = false;
    }
}
