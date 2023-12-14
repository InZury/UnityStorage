using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public virtual void Move(Vector3 direction)
    {
        transform.Translate(direction);
    }
}
