using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    void EnterState(PlayerStateMachine stateMachine);

    void UpdateState(PlayerStateMachine stateMachine);

    void FixedUpdateState(PlayerStateMachine stateMachine);

    void ExitState(PlayerStateMachine stateMachine);
}
