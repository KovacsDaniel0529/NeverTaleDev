using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private PlayerRespawn playerRespawn;
    public GameObject defaultFlag;
    public GameObject flag;
    public float[] savePosition;
    public KeyScript hasKey;
    public CoinScript coin;
    public Health health;



    // Start is called before the first frame update
    void Start()
    {
        playerRespawn = GameObject.Find("Character").GetComponent<PlayerRespawn>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Character")
        {
            playerRespawn.respawnPoint = transform.position;
            defaultFlag.SetActive(true);
            flag.SetActive(false);
            SaveCheckpoint();
        }
    }
    public void SaveCheckpoint()
    {
        int keystuff = 0;
        if (hasKey.haveAKey)
        {
            keystuff = 1;
        }
        
        //playerRespawn.respawnPoint;
        // pozíció
        PlayerPrefs.SetString("PlayerX", Convert.ToString(playerRespawn.transform.position.x));
        PlayerPrefs.SetString("PlayerY", Convert.ToString(playerRespawn.transform.position.y));
        PlayerPrefs.SetString("PlayerZ", Convert.ToString(playerRespawn.transform.position.z));
        PlayerPrefs.SetInt("hasKey", keystuff);
        PlayerPrefs.SetInt("hasCoins", coin.ScoreNum);
        PlayerPrefs.SetFloat("hasHP", health.tHP);

        PlayerPrefs.Save();

        //transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
        // hp és élet szám
        // Coin
        // kulcs 
    }
}
