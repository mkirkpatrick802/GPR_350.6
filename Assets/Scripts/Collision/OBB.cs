using UnityEngine;
using System.Collections;

public class OBB : PhysicsCollider
{
    public float halfWidth;
    public float halfHeight;
    public float halfLength;
    public Quaternion rotation;
    
    public float[] bounds = new float[3];
    
    public override Shape shape => Shape.OBB;
    
    private void Awake()
    {
        var localTransform = transform;
        var localScale = localTransform.localScale;
        halfWidth = localScale.x / 2;
        halfHeight = localScale.y / 2;
        halfLength = localScale.z / 2;
        
        bounds[0] = halfWidth;
        bounds[1] = halfHeight;
        bounds[2] = halfLength;
    }
}
