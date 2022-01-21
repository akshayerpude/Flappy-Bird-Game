using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    
    void Start()
    {
        Invoke("GoToMenu",2f);
    }
   
   void GoToMenu()
   {
       SceneManager.LoadScene("Menu");
   }
}
