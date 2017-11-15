using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartObject : MonoBehaviour
{
    public Vector2 Center
    {
        get
        {
            return new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f);
        }
    }
}
