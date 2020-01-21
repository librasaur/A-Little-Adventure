﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : Interactable
{
    public override void MarkAsPickedUp()
    {
        toBeInteractedBy.GetComponent<RaineController>().hasRope = true;
    }
}