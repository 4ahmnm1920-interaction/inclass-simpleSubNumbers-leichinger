﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnsubNumbers;
    public Button btnReset;
    int index = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnsubNumbers.interactable = true;  

        result.text = "Result";
        ipfVarA.text = "0";
        ipfVarB.text = "0";
    }
 
    public void SubNumbersOnKlick()
    {
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int SubResult = variableA - variableB;
        result.text = SubResult.ToString();
        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnsubNumbers.interactable = false;  
        
    }
}
