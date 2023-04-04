using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStarted : MonoBehaviour
{
    public int CutSceneSkip = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            CutSceneSkip = 1;
            PlayerPrefs.SetInt("PlayerStarted", CutSceneSkip);
            PlayerPrefs.Save();
        }
    }
}
