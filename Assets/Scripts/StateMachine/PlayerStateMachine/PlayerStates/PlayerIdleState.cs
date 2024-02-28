using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerOnGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, true);
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, false);
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        //throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            stateMachine.ChangeState(stateMachine.RunState);
        }
        base.UpdateState(stateMachine);
    }
}
