using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
//[RequireComponent(typeof(MovementConfig))]
public class SideMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float accelaration, decelaration;

    [SerializeField]
    private float velPower;


    private ISideMove sideMoveBehavior;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        sideMoveBehavior = GetComponent<ISideMove>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
    }

    public void Move()
    {
        sideMoveBehavior.UpdateInput();

        float x = sideMoveBehavior.X;

        /*float targetSpeed = x * speed;

        float speedDiff = targetSpeed - rb.velocity.x;

        float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? accelaration : decelaration;

        float movement = Mathf.Pow(Mathf.Abs(speedDiff) * accelRate, velPower) * Mathf.Sign(speedDiff);

        rb.AddForce(movement * Vector2.right);*/


        rb.velocity = new Vector2(x * speed, rb.velocity.y);
    }

    public void StopMove()
    {
        rb.velocity = Vector2.zero;
    }
}
