using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDashState : PlayerAbilityState
{
    public PlayerDashState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        PlayerAbilityState.isAbilityDone = false;
        stateMachine.MovementConfig.Dash.DoDash();

        //Debug.Log("Dash!!");
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, true);
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        //Debug.Log("Stop Dash!!");
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, false);
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        base.FixedUpdateState(stateMachine);
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        if(!stateMachine.MovementConfig.Dash.IsDashing)
        {
            PlayerAbilityState.isAbilityDone = true;
        }
        base.UpdateState(stateMachine);
    }
}
