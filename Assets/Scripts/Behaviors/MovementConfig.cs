using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementConfig : MonoBehaviour
{
    [field: SerializeField]
    public SideMove SideMove { get; private set; }

    [field: SerializeField]
    public Jump Jump { get; private set; }

    [field: SerializeField]
    public Dash Dash { get; private set; }

    [field: SerializeField]
    public Flip Flip { get; private set; }

    [field: SerializeField]
    public Rigidbody2D RigidBody { get; private set; }

    [field: SerializeField]
    public Transform GroundCheck { get; private set; }

    [field: SerializeField]
    public float GroundCheckRadius { get; private set; }

    [field: SerializeField]
    public LayerMask GroundLayer { get; private set; }

    [field: SerializeField]
    public Animator Animator { get; private set; }

    private void OnEnable()
    {
        Application.targetFrameRate = -1;
    }

    private void Start()
    {
        SideMove = GetComponent<SideMove>();
        Jump = GetComponent<Jump>();
    }

    public bool IsOnGround()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);
    }
}
