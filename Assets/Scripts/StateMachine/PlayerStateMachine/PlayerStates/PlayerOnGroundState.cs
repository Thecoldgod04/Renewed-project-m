using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnGroundState : PlayerNonAbilityState
{
    public PlayerOnGroundState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        //If groundCheck is not on ground then move to OnAirState
        if(!stateMachine.MovementConfig.IsOnGround())
        {
            stateMachine.ChangeState(stateMachine.OnAirState);
        }
/*
        if(Input.GetKeyDown(KeyCode.W))
        {
            stateMachine.MovementConfig.Jump.DoJump();
        }*/
        base.UpdateState(stateMachine);
    }
}
