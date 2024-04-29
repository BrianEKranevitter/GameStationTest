using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RayCastProvider
{
    public static RaycastHit2D provideRaycast(Vector2 origin, Vector2 direction, float distance, LayerMask mask)
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(origin, direction, distance, mask);
        return hit;
    }
}