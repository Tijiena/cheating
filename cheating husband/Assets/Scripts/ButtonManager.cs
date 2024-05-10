using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject homePage;
    public GameObject messagePage;
    public GameObject searchPage;
    public GameObject dmPage;

    public GameObject abbyDM;
    public GameObject cathyDM;
    public GameObject zbyDM;
    public GameObject bellaDM;
    public GameObject echoDM;

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
        echoPage.SetActive(false);
        resturantPage.SetActive(false);
        dmPage.SetActive(false);
    }

    public void MessagesButton()
    {
        messagePage.SetActive(true);
        dmPage.SetActive(true);

        homePage.SetActive(false);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        echoPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
    }

    public void SearchButton()
    {
        searchPage.SetActive(true);
        messagePage.SetActive(true);
        dmPage.SetActive(true);

        homePage.SetActive(true);
        abbyPage.SetActive(false);
        cathyPage.SetActive(false);
        zbyPage.SetActive(false);
        bellaPage.SetActive(false);
        echoPage.SetActive(false);
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
        dmPage.SetActive(false);
        echoPage.SetActive(false);
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
        dmPage.SetActive(false);
        echoPage.SetActive(false);
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
        dmPage.SetActive(false);
        echoPage.SetActive(false);
    }

    public void ZbyProfile()
    {
        homePage.SetActive(true);
        zbyPage.SetActive(true);

        messagePage.SetActive(false);
        cathyPage.SetActive(false);
        abbyPage.SetActive(false);
        bellaPage.SetActive(false);
        echoPage.SetActive(false);
        searchPage.SetActive(false);
        resturantPage.SetActive(false);
        dmPage.SetActive(false);
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
        dmPage.SetActive(false);
    }

    public void AbbyDm()
    {
        abbyDM.SetActive(true);

        cathyDM.SetActive(false);
        zbyDM.SetActive(false);
        bellaDM.SetActive(false);
        echoDM.SetActive(false);
    }

    public void BellaDm()
    {
        bellaDM.SetActive(true);

        cathyDM.SetActive(false);
        zbyDM.SetActive(false);
        abbyDM.SetActive(false);
        echoDM.SetActive(false);
    }

    public void CathyDm()
    {
        cathyDM.SetActive(true);

        abbyDM.SetActive(false);
        zbyDM.SetActive(false);
        bellaDM.SetActive(false);
        echoDM.SetActive(false);
    }

    public void ZbyDm()
    {
        zbyDM.SetActive(true);

        cathyDM.SetActive(false);
        abbyDM.SetActive(false);
        bellaDM.SetActive(false);
        echoDM.SetActive(false);
    }

    public void EchoDm()
    {
        echoDM.SetActive(true);

        cathyDM.SetActive(false);
        zbyDM.SetActive(false);
        bellaDM.SetActive(false);
        abbyDM.SetActive(false);
    }

}
