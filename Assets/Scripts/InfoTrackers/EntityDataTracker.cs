using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntityDataTracker : MonoBehaviour
{
    [SerializeField]
    private GameObject entity;

    [SerializeField]
    private TextMeshProUGUI velocityText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityText.text = "Velocity: " + entity.GetComponent<Rigidbody2D>().velocity;
    }
}
