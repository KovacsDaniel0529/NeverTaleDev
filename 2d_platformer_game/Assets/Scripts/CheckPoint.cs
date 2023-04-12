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
    public HealthBar healthBar;
    public Life fullLife;



    // Start is called before the first frame update
    void Start()
    {
        playerRespawn = GameObject.Find("Character").GetComponent<PlayerRespawn>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (flag.activeSelf)
        {
            FindObjectOfType<AudioManager>().Play("CheckSound");
        }
        if (collision.gameObject.name == "Character")
        {
            playerRespawn.respawnPoint = transform.position;
            defaultFlag.SetActive(true);
            flag.SetActive(false);
            SaveCheckpoint();
        }
    }
    public void SaveCheckpoint()
    {
        int keystuff;
        if (hasKey.haveAKey)
        {
            keystuff = 1;
        }
        else
        {
            keystuff = 0;
        }
        
        //playerRespawn.respawnPoint;
        // pozíció
        PlayerPrefs.SetFloat("PlayerX", playerRespawn.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", playerRespawn.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", playerRespawn.transform.position.z);
        PlayerPrefs.SetInt("hasKey", keystuff);
        PlayerPrefs.SetInt("hasCoins", coin.ScoreNum);
        PlayerPrefs.SetFloat("hasHP", HealthBar.totalHealth);
        PlayerPrefs.SetInt("FullLife", Life.fullLife );

        PlayerPrefs.Save();

        //transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
        // hp és élet szám
        // Coin
        // kulcs 
    }
}
