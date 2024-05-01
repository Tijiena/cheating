using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckSearch : MonoBehaviour
{
    public TMP_InputField searchPanel;
    public string resturantName;


    public void CheckInput()
    {
        if (searchPanel.text == resturantName)
        {
            Debug.Log("account found");
        }
        else
        {
            Debug.Log("no accounts found");
        }
    }

}
