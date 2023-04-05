using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    bool _destroy = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "arrow")
        {
            if (!_destroy)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
