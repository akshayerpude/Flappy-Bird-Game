using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

   public  void GoToSettingsScreen()
    {
        MenuController.Instace.SwitchScreen(EMenuScreens.SETTINGS);
    }
}
