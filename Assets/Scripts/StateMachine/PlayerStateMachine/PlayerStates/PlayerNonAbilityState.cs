using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNonAbilityState : PlayerBaseState
{
    public PlayerNonAbilityState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
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
        //Dash
        if(Input.GetKeyDown(stateMachine.KeyBindingConfig.DashKey) &&
            stateMachine.MovementConfig.Dash.CanDash)
        {
            stateMachine.ChangeState(stateMachine.DashState);
        }
        //Jump
        else if(Input.GetKeyDown(stateMachine.KeyBindingConfig.JumpKey))
        {
            if(stateMachine.MovementConfig.IsOnGround())
            {
                stateMachine.ChangeState(stateMachine.JumpState);
            }
            else if(CanPlayerDoubleJump())
            {
                stateMachine.ChangeState(stateMachine.JumpState);
            }
        }
        //Attack
        else if(Input.GetKeyDown(stateMachine.KeyBindingConfig.AttackKey))
        {
            stateMachine.ChangeState(stateMachine.AttackState);
        }
    }

    private bool CanPlayerDoubleJump()
    {
        //Todo: check if player achieved double jump ability
        return false;
    }
}
