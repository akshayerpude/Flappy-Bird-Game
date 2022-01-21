using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] BirdAnimator animRef = null;
    [SerializeField] Rigidbody2D birdRB = null;
    
    void Start()
    {
        birdRB.simulated=false;
    }

    
    private void OnEnable()
    {
        EventManager.Instance.RegisterEvent(EEvent.GAME_START, GameStart);
    }

    private void OnDisable()
    {
        EventManager.Instance.UnRegisterEvent(EEvent.GAME_START, GameStart);
    }

    void GameStart()
    {
        Debug.Log("Bird Controller: gamestart");
        birdRB.velocity = Vector3.zero;
        birdRB.simulated = true;
        State = EBirdState.FLY;
    }

    public EBirdState State
    {
        get {return animRef.State;}
        set {animRef.State = value;}
    }

    void Update()
    {
        if(State)
    }
}

