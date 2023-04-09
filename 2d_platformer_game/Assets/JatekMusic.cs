using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JatekMusic : MonoBehaviour
{
    void ZeneBona()
    {
        FindObjectOfType<AudioManager>().Play("JatekTheme");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ZeneBona", 0f);
    }
}
