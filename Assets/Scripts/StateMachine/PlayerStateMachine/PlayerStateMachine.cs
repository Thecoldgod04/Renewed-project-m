using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public IPlayerState CurrentState { get; private set; }
    public PlayerNonAbilityState NonAbilityState { get; private set; }
    public PlayerOnGroundState OnGroundState { get; private set; }
    public PlayerIdleState IdleState { get; private set; }
    public PlayerRunState RunState { get; private set; }
    public PlayerOnAirState OnAirState { get; private set; }
    public PlayerAbilityState AbilityState { get; private set; }
    public PlayerJumpState JumpState { get; private set; }
    public PlayerDashState DashState { get; private set; }
    public PlayerAttackState AttackState { get; private set; }

    [field: SerializeField]
    public MovementConfig MovementConfig { get; private set; }

    [field: SerializeField]
    public KeyBindings KeyBindingConfig { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        InitStates();

        MovementConfig = GetComponent<MovementConfig>();

        ChangeState(IdleState);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.UpdateState(this);
    }

    private void FixedUpdate()
    {
        CurrentState.FixedUpdateState(this);
    }

    private void InitStates()
    {
        OnGroundState = new PlayerOnGroundState(this, "", "");
        IdleState = new PlayerIdleState(this, "Player_idle_anim", "isIdling");
        RunState = new PlayerRunState(this, "Player_run_anim", "isRunning");
        OnAirState = new PlayerOnAirState(this, "Player_on_air_anim", "isOnAir");
        AbilityState = new PlayerAbilityState(this, "", "");
        JumpState = new PlayerJumpState(this, "Player_jump_anim", "triggerJump");
        DashState = new PlayerDashState(this, "Player_dash_anim", "isDashing");
        AttackState = new PlayerAttackState(this, "Player_attack_anim", "isAttacking");
    }

    public void ChangeState(IPlayerState state)
    {
        if(CurrentState == null)
        {
            CurrentState = IdleState;
        }

        CurrentState.ExitState(this);
        CurrentState = state;
        CurrentState.EnterState(this);
    }
}
