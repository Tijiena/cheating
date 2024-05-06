using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject homePage;
    public GameObject messagePage;
    public GameObject searchPage;

    public GameObject abbyPage;
    public GameObject cathyPage;
    public GameObject zbyPage;
    public GameObject bellaPage;
    public GameObject echoPage;

    public GameObject resturantPage;

    public void HomeButton()
    {
        homePage.SetActive(true);

        messagePage.SetActive(false);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void MessagesButton()
    {
        messagePage.SetActive(true);

        homePage.SetActive(false);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void SearchButton()
    {
        searchPage.SetActive(true);
        messagePage.SetActive(true);

        homePage.SetActive(true);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void AbbyProfile()
    {
        homePage.SetActive(true);
        abbyPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void BellaProfile()
    {
        homePage.SetActive(true);
        bellaPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void CathyProfile()
    {
        homePage.SetActive(true);
        cathyPage.SetActive(true);

        messagePage.SetActive(false);
        abbyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void ZbyProfile()
    {
        homePage.SetActive(true);
        zbyPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        abbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void EchoProfile()
    {
        homePage.SetActive(true);
        echoPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        abbyPage.SetActive(false);
        bellaPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

}
