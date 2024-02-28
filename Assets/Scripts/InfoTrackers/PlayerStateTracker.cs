using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStateTracker : MonoBehaviour
{
    [SerializeField]
    private PlayerStateMachine playerStateMachine;

    [SerializeField]
    private TextMeshProUGUI stateText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateText.text = "Current State: " + playerStateMachine.CurrentState;
    }
}
