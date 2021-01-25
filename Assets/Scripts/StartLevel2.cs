using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel2 : MonoBehaviour
{
     public void PlayPressed()
     {
         SceneManager.LoadScene("lvl2");
     }
}