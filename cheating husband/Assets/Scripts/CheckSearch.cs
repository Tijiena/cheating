using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckSearch : MonoBehaviour
{
    public TMP_InputField searchPanel;
    public string resturantName;

    public GameObject resturantPage;
    public GameObject searchBox;
    public GameObject chatPage;
    public GameObject dmPage;

    public void CheckInput()
    {
        if (searchPanel.text == resturantName)
        {
            Debug.Log("account found");
            resturantPage.SetActive(true);
            searchBox.SetActive(false);
            chatPage.SetActive(false);
            dmPage.SetActive(false);
            
        }
        else
        {
            Debug.Log("no accounts found");
        }
    }

}
