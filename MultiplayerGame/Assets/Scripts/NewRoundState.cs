using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoundState : BaseState
{
    public override void OnStateEnter()
    {
        Debug.Log("Starting new round");
    }

    public override void OnStateExit()
    {
        Debug.Log("Round Finished");
    }

    public override void OnStateFixedUpdate()
    {

    }

    public override void OnStateUpdate()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
