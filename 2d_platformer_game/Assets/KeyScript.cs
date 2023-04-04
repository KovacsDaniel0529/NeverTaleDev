using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    public bool haveAKey = false;
    private bool _collected = false;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        haveAKey = false;
        image.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Key")
        {
            Debug.Log("Meg van a kulcs");
            if (!_collected)
            {
                Destroy(collision.gameObject);
                haveAKey = true;
                image.enabled = true;

            }

        }
    }
}
