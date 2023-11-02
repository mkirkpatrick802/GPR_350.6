using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AABB : PhysicsCollider
{
    public float halfWidth;
    public float halfHeight;
    public float halfLength;
    
    public override Shape shape => Shape.AABB;

    private void Awake()
    {
        var localScale = transform.localScale;
        halfWidth = localScale.x / 2;
        halfHeight = localScale.y / 2;
        halfLength = localScale.z / 2;
    }
}
