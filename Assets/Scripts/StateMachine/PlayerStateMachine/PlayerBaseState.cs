using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IPlayerState
{
    protected AnimationClip animation;

    protected string animationParameter;

    public PlayerBaseState(PlayerStateMachine stateMachine, string animationName, string animationParameter)
    {
        if(stateMachine.MovementConfig.Animator != null)
        {
            animation = GetAnimation(stateMachine.MovementConfig.Animator, animationName);
        }

        this.animationParameter = animationParameter;
    }

    public virtual void EnterState(PlayerStateMachine stateMachine)
    {
        
    }

    public virtual void ExitState(PlayerStateMachine stateMachine)
    {
        
    }

    public virtual void FixedUpdateState(PlayerStateMachine stateMachine)
    {
        
    }

    public virtual void UpdateState(PlayerStateMachine stateMachine)
    {
        
    }

    private AnimationClip GetAnimation(Animator animator, string animationName)
    {
        AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
        foreach (AnimationClip clip in clips)
        {
            if (clip.name == animationName)
                return clip;
        }

        return null;
    }

    protected void TriggerAnim(PlayerStateMachine stateMachine)
    {
        //animation.frameRate = 60;
        stateMachine.MovementConfig.Animator.SetTrigger(animationParameter);
    }

    protected void ResetTriggerAnim(PlayerStateMachine stateMachine)
    {
        stateMachine.MovementConfig.Animator.ResetTrigger(animationParameter);
    }

    protected void EnableAnim(PlayerStateMachine stateMachine)
    {
        //animation.frameRate = 60;
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, true);
    }

    protected void DisableAnim(PlayerStateMachine stateMachine)
    {
        stateMachine.MovementConfig.Animator.SetBool(animationParameter, false);
    }
}
