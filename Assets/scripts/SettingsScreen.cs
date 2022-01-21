using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScreen : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    public void BackClicked()
    {
        MenuController.Instace.SwitchScreen(EMenuScreens.HOME);
    }
}
