using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckPassword : MonoBehaviour
{
    public TMP_InputField passwordPanel;
    public string myPassword;
    public GameObject loadingScreen;


    public void CheckInput()
    {
        if (passwordPanel.text == myPassword)
        {
            loadingScreen.SetActive(true);
            Invoke("NextLevel", 5f);
        }
        else
        {
            Debug.Log("incorrect");
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("ins_scene");
    }
}
