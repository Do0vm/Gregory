// Assets/Scripts/MultiPressInteractive.cs
using UnityEngine;
using System.Collections.Generic;

public class MultiPressInteractive : Interactive
{
    [Tooltip("How many total presses before the door opens")]
    public int requiredPresses = 3;

    private static int _pressCount = 0;
    private bool _pressed = false;

    public override void OnInteraction()
    {
        if (_pressed) return;      // each button only counts once
        _pressed = true;
        _pressCount++;

        if (_pressCount < requiredPresses)
            return;

        base.OnInteraction();

        if (onlyOnce)
            GetComponent<Collider>().enabled = false;
    }
}
