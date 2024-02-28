using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "KeyBindingConfigurations", menuName = "Configuration/Key Binding")]
public class KeyBindings : ScriptableObject
{
    [field: SerializeField]
    public KeyCode MoveLeftKey { get; private set; }

    [field: SerializeField]
    public KeyCode MoveRightKey { get; private set; }

    [field: SerializeField]
    public KeyCode JumpKey { get; private set; }

    [field: SerializeField]
    public KeyCode DashKey { get; private set; }

    [field: SerializeField]
    public KeyCode CrouchKey { get; private set; }

    [field: SerializeField]
    public KeyCode AttackKey { get; private set; }

    [field: SerializeField]
    public KeyCode HealKey { get; private set; }
}
