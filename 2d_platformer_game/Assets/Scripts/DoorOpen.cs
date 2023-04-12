using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    public GameObject noCoin;
    public GameObject noKey;
    public GameObject noKeyAndNoCoin;
    public CoinScript coin;
    public KeyScript key;
    public float changeTime;
    public string sceneName;
    private bool hasPlayer;
    public Dialogue[] dialogue;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && hasPlayer)
        {
            
            Debug.Log(" E lenyomva");
            if (coin.ScoreNum < 25 && key.haveAKey == true)
            {
                noCoin.SetActive(true);
                Debug.Log("Elivleg Nincs péz");
            }
            else if (key.haveAKey == false && coin.ScoreNum >= 25)
            {
                noKey.SetActive(true);
                Debug.Log("Elivleg Nincs kulcs");
            }
            else if (key.haveAKey == false && coin.ScoreNum < 25)
            {
                noKeyAndNoCoin.SetActive(true);
                Debug.Log("Elivleg Nincs semmi");
            }
            else if (coin.ScoreNum >= 25 && key.haveAKey == true)
            {
                changeTime -= Time.deltaTime;
                if (changeTime <= 0)
                {
                    SceneManager.LoadScene(sceneName);
                    PlayerPrefs.DeleteAll();
                }

                Debug.Log("Minden jó");
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "gate")
        {
            hasPlayer = true;
            Debug.Log("Elérte a kaput");
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "gate")
        {
            foreach (var item in dialogue)
            {
                item.index = 0;
            }
            
            hasPlayer = false;
            Debug.Log("Elhagyta a kaput");

        }
    }
}
