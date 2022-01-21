using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] Text countDown = null;
    public bool gamestart = false;
        void Start()
    {
        
    }

    private void OnEnable()
    {
        countDown.text = "3";
        StartCoroutine(CountDownRoutine());
    }

    IEnumerator CountDownRoutine()
    {
        int counter = 3;
        for(int i=0; i<counter; i++)
        {
            countDown.text = (counter-i).ToString();
            yield return new WaitForSeconds(1);
        }
        countDown.gameObject.SetActive(false);
        EventManager.Instance.ExecuteEvent(EEvent.GAME_START);
    }
}
