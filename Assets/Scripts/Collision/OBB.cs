using UnityEngine;
using System.Collections;

public class OBB : PhysicsCollider
{
    public float halfWidth;
    public float halfHeight;
    public float halfLength;
    public Quaternion rotation;
    
    public override Shape shape => Shape.OBB;
    
    private void Awake()
    {
        var localTransform = transform;
        var localScale = localTransform.localScale;
        halfWidth = localScale.x / 2;
        halfHeight = localScale.y / 2;
        halfLength = localScale.z / 2;

        rotation = localTransform.rotation;
    }
}
