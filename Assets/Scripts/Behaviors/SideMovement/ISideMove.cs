using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISideMove
{
    float X { get; }

    void UpdateInput();
}
