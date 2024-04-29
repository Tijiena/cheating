using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject homePage;
    public GameObject messagePage;

    public GameObject abbyPage;
    public GameObject cathyPage;
    public GameObject zbyPage;

    public void HomeButton()
    {
        homePage.SetActive(true);

        messagePage.SetActive(false);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
    }

    public void MessagesButton()
    {
        messagePage.SetActive(true);

        homePage.SetActive(false);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
    }

    public void AbbyProfile()
    {
        homePage.SetActive(true);
        abbyPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
    }

    public void BellaProfile()
    {
        messagePage.SetActive(false);
    }

    public void CathyProfile()
    {
        homePage.SetActive(true);
        cathyPage.SetActive(true);

        messagePage.SetActive(false);
        abbyPage.SetActive(false);
        zbyPage.SetActive(false);
    }

    public void ZbyProfile()
    {
        homePage.SetActive(true);
        zbyPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        abbyPage.SetActive(false);
    }
}
