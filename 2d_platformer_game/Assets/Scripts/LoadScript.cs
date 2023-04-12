using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour
{
    public GameObject character;
    public KeyScript hasKey;
    public CoinScript coin;
    //public HealthBar healthBar;
    //public Life fullLife;


    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerX") == true)
        {
            LoadGame();
        }
    }

    public void LoadGame()
    {
        character.transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
        //healthBar.tHP = PlayerPrefs.GetFloat("hasHP");
        hasKey.haveAKey = (PlayerPrefs.GetInt("hasKey") != 0);
        coin.ScoreNum = PlayerPrefs.GetInt("hasCoins");
        //fullLife.fullLife = PlayerPrefs.GetInt("FullLife");
    }
}
