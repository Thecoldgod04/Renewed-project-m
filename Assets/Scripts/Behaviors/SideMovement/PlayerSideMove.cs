using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSideMove : MonoBehaviour, ISideMove
{
    public float X { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateInput()
    {
        X = Input.GetAxisRaw("Horizontal");
    }
}
