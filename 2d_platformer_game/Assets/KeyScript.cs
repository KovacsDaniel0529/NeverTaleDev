using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    public bool haveAKey = false;
    private bool _collected = false;
    public Image image;
    public GameObject[] keyOff;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("hasKey") != 0)
        {
            image.enabled = true;
            keyOff = GameObject.FindGameObjectsWithTag("Key");
            Destroy(this);
        }
        else
        {
            haveAKey = false;
            image.enabled = false;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Key")
        {
            Debug.Log("Meg van a kulcs");
            if (!_collected)
            {
                FindObjectOfType<AudioManager>().Play("KeySound");
                Destroy(collision.gameObject);
                haveAKey = true;
                image.enabled = true;

            }

        }
    }

}
