using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerAbilityState
{
    private float attackTime;

    private float currentAttackTime;

    public PlayerAttackState(PlayerStateMachine stateMachine, string animationName, string animationParameter) : base(stateMachine, animationName, animationParameter)
    {
    }

    public override void EnterState(PlayerStateMachine stateMachine)
    {
        PlayerAbilityState.isAbilityDone = false;
        //attackSlash.SetActive(true);
        currentAttackTime = 0f;

        if (animation != null)
        {
            attackTime = animation.length;
        }
        else
        {
            attackTime = 1f;
        }

        //Debug.LogError(animation);

        EnableAnim(stateMachine);

        base.EnterState(stateMachine);
    }

    public override void ExitState(PlayerStateMachine stateMachine)
    {
        //attackSlash.SetActive(false);

        DisableAnim(stateMachine);

        base.ExitState(stateMachine);
    }

    public override void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        base.FixedUpdateState(stateMachine);
    }

    public override void UpdateState(PlayerStateMachine stateMachine)
    {
        if(currentAttackTime >= attackTime)
        {
            PlayerAbilityState.isAbilityDone = true;
        }
        else
        {
            currentAttackTime += Time.deltaTime;

            stateMachine.MovementConfig.SideMove.Move();
        }

        base.UpdateState(stateMachine);
    }
}
