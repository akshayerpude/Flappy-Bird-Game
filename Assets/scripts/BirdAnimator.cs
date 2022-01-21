using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimator : MonoBehaviour
{
    
    [SerializeField] Animator animRef = null;

    private string[] bState = {"idle", "fly", "die"};
    
    private EBirdState _state;
    void Start()
    {
        State = EBirdState.IDLE;
    }

    public EBirdState State
    {
        get {return _state;}
        set
         {
             _state = value;
             animRef.SetTrigger(bState[(int)_state]);
         }
    }

    
}
 