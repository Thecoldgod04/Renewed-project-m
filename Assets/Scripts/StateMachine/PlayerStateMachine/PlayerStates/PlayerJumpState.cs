using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerAbilityState
{
    public PlayerJumpState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        PlayerAbilityState.isAbilityDone = false;
        stateMachine.MovementConfig.Jump.DoJump();
        PlayerAbilityState.isAbilityDone = true;

        TriggerAnim(stateMachine);
        //EnableAnim(stateMachine);
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        ResetTriggerAnim(stateMachine);
        //DisableAnim(stateMachine);
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        base.FixedUpdateState(stateMachine);
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        base.UpdateState(stateMachine);
    }

    private void DoSideMove(PlayerStateMachine stateMachine)
    {
        stateMachine.MovementConfig.SideMove.Move();
    }
}
