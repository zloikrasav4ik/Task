using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEscape : MonoBehaviour
{
    public GameObject myPanel;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
             myPanel.SetActive (false);
        } 
    }
}
