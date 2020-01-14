using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using static System.Math;


public class ConvertToDecimal : MonoBehaviour
{
    int sum;
    string bi;
    bool reset;
    private Text lblText;
    void Start()
    {
        sum = 0;
        bi = "";
        reset = false;

        lblText = GetComponent<Text>();
    }
    
    
    void Update()
    {
        if (reset)
        {
            sum = 0;
            bi = "";
            reset = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0)){
            sum *=2;
            bi += "0";
            lblText.text = bi;
            //display bi on label
        } else if (Input.GetKeyDown(KeyCode.Alpha1)) {
            sum *=2;
            sum ++;
            bi += "1";
            lblText.text = bi;
            //display bi on label
        }
        else if (Input.GetKeyDown(KeyCode.Space)){
            lblText.text = sum.ToString();
            reset = true;
        }
    }
}
