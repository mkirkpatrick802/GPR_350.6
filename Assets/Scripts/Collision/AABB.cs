using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABB : PhysicsCollider
{
    // TODO: YOUR CODE HERE
    public override Shape shape => Shape.AABB;
}
