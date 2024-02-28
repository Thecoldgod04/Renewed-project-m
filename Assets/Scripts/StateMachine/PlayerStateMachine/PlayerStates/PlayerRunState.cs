using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : PlayerOnGroundState
{
    public PlayerRunState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
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
        float input = Input.GetAxisRaw("Horizontal");
        if (input == 0)
        {
            stateMachine.ChangeState(stateMachine.IdleState);
        }
        stateMachine.MovementConfig.SideMove.Move();
        stateMachine.MovementConfig.Flip.DoFlipByInput(input);
        base.UpdateState(stateMachine);
    }
}
