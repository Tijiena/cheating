using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseVideo : MonoBehaviour
{
    public GameObject videoScene;
    public GameObject background;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            videoScene.SetActive(false);
            background.SetActive(false);
            Cursor.visible = true;
        }
    }
}
