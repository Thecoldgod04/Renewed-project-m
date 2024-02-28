using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityState : PlayerBaseState
{
    protected static bool isAbilityDone = true;

    public PlayerAbilityState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
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
        if(isAbilityDone)
        {
            /*if(!stateMachine.MovementConfig.IsOnGround())
            {
                stateMachine.ChangeState(stateMachine.OnAirState);
            }
            else
            {
                stateMachine.ChangeState(stateMachine.IdleState);
            }*/
            stateMachine.ChangeState(stateMachine.IdleState);
        }
    }
}
