using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnAirState : PlayerNonAbilityState
{
    public PlayerOnAirState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        EnableAnim(stateMachine);
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        DisableAnim(stateMachine);
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        if (stateMachine.MovementConfig.IsOnGround())
        {
            stateMachine.ChangeState(stateMachine.IdleState);
        }

        float input = Input.GetAxis("Horizontal");
        if (input != 0)
        {
            stateMachine.MovementConfig.SideMove.Move();
            stateMachine.MovementConfig.Flip.DoFlipByInput(input);
        }

        if (Input.GetKeyUp(stateMachine.KeyBindingConfig.JumpKey))
        {
            stateMachine.MovementConfig.Jump.StopJump();
        }
        base.UpdateState(stateMachine);
    }
}
