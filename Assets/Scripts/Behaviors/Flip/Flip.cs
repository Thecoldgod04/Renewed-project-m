using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    [SerializeField]
    private bool isFacingRight;

    [Header("For Flipping By Target Position")]
    [SerializeField]
    private float targetOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoFlipByInput(float input)
    {
        if (input > 0 && isFacingRight == false)
        {
            TriggerFlip();
        }
        else if (input < 0 && isFacingRight == true)
        {
            TriggerFlip();
        }
    }

    public void DoFlipByTargetPosition(Transform target)
    {
        if (transform.position.x - targetOffset > target.position.x && isFacingRight == true)        //Target is to the left
        {
            TriggerFlip();
            //Debug.Log("L");
        }
        else if (transform.position.x + targetOffset < target.position.x && isFacingRight == false)
        {
            TriggerFlip();
            //Debug.Log("R");
        }
    }

    public void TriggerFlip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        //Debug.Log(transform.localScale.x);
        isFacingRight = !isFacingRight;
    }
}
