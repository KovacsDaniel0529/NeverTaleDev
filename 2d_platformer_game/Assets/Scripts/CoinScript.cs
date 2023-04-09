using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinScript : MonoBehaviour
{

    public int ScoreNum;
    public TextMeshProUGUI textCoin;
    private bool _collected = false;
    // Start is called before the first frame update
    public void Start()
    {
        ScoreNum = PlayerPrefs.GetInt("hasCoins");
        textCoin.text = ScoreNum.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            Debug.Log("Meg van a péz");
            FindObjectOfType<AudioManager>().Play("CoinSound");
            if (!_collected)
            {
                Destroy(collision.gameObject);
                ScoreNum += 1;
                textCoin.text = ScoreNum.ToString();
                
            }
            



        }
        

    }

}
