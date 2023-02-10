using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    protected override bool CanDespawn()
    {
        return false;
    }
}