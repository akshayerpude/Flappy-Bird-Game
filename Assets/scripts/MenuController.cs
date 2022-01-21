using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private static MenuController _instance = null;

    [SerializeField] EMenuScreens ActiveScreen;
    [SerializeField] GameObject[] menuScreens;

    void Awake()
    {
        if(Instace==null)
        {
            Instace=this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        Init();
    }
    void Init()
   {
       SwitchScreen(ActiveScreen);
   }
    public static MenuController Instace
    {
        get{return _instance;}
        private set {_instance=value;}
    }

    public void SwitchScreen(EMenuScreens val)
    {
        for(int i=1; i<menuScreens.Length; i++)
        {
            if(i==(int)val)
            menuScreens[i].SetActive(true);
            else
            menuScreens[i].SetActive(false);
        }
    }
    
    
}
