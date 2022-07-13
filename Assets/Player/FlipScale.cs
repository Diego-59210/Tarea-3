using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScale : MonoBehaviour
{
    public void Flip(bool side)
    {
        if (side)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);   
        }
        else
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
