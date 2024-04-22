using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    public GameObject hintText;

    public void ButtonPressed()
    {
        hintText.SetActive(true);
    }
}
