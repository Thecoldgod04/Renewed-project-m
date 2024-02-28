using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float dashTime;

    [SerializeField]
    private float dashCooldown;

    [SerializeField]
    private float dashForce;

    [Header("For Objects That Dash The Direction They're Facing ONLY")]
    [SerializeField]
    private Transform objectThatDoesFlips;

    public bool CanDash { get; private set; }
    public bool IsDashing { get; private set; } // This variable/field is public in order to allow other classes to know if the enity is currently dashing or not

    // Start is called before the first frame update
    void Start()
    {
        CanDash = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoDash(float input = 0)
    {
        if(CanDash && !IsDashing)
        {
            StartCoroutine(StartDash(input));
        }
    }

    IEnumerator StartDash(float input)
    {
        CanDash = false;
        IsDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;

        float direction = 0;
        if (input == 0)
        {
            direction = objectThatDoesFlips.localScale.x;
        }
        else
        {
            direction = input;
        }

        rb.velocity = new Vector2(direction * dashForce, 0f);
        yield return new WaitForSeconds(dashTime);

        IsDashing = false;
        rb.gravityScale = originalGravity;
        rb.velocity = Vector2.zero;

        yield return new WaitForSeconds(dashCooldown);

        CanDash = true;
    }
}
