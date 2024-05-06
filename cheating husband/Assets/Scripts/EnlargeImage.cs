using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeImage : MonoBehaviour
{
    public GameObject post1;
    public GameObject post2;
    public GameObject post3;
    public GameObject post4;
    public GameObject post5;
    public GameObject post6;
    public GameObject imageBG;


    public void EnlargePost1()
    {
        imageBG.SetActive(true);
        post1.SetActive(true);

        post2.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post5.SetActive(false);
        post6.SetActive(false);
    }

    public void EnlargePost2()
    {
        imageBG.SetActive(true);
        post2.SetActive(true);

        post1.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post5.SetActive(false);
        post6.SetActive(false);
    }

    public void EnlargePost3()
    {
        imageBG.SetActive(true);
        post3.SetActive(true);

        post1.SetActive(false);
        post2.SetActive(false);
        post4.SetActive(false);
        post5.SetActive(false);
        post6.SetActive(false);
    }

    public void EnlargePost4()
    {
        imageBG.SetActive(true);
        post4.SetActive(true);

        post1.SetActive(false);
        post2.SetActive(false);
        post3.SetActive(false);
        post5.SetActive(false);
        post6.SetActive(false);
    }

    public void EnlargePost5()
    {
        imageBG.SetActive(true);
        post5.SetActive(true);

        post2.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post1.SetActive(false);
        post6.SetActive(false);
    }

    public void EnlargePost6()
    {
        imageBG.SetActive(true);
        post6.SetActive(true);

        post2.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post1.SetActive(false);
        post5.SetActive(false);
    }

    public void ClosePage()
    {
        imageBG.SetActive(false);
    }
}
