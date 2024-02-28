using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce;

    [field: SerializeField]
    public int CurrentJumps { get; private set; }

    [field: SerializeField]
    public bool CanDoubleJump { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CurrentJumps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    public void DoJump()
    {
        JumpUp(1);
    }

    public void StopJump()
    {
        if (rb.velocity.y > 0)
        {
            JumpUp(0.25f);
        }
    }
    private void JumpUp(float percentage)
    {
        //rb.AddForce(Vector2.up * jumpForce * percentage, ForceMode2D.Impulse);

        rb.velocity = Vector2.up * jumpForce * percentage;
    }

    public void SetCanDoubleJump(bool canDoubleJump)
    {
        CanDoubleJump = canDoubleJump;
    }
}
