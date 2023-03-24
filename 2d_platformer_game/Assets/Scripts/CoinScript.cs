using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinScript : MonoBehaviour
{

    private int ScoreNum;
    public TextMeshProUGUI textCoin;
    private bool _collected = false;
    // Start is called before the first frame update
    void Start()
    {
        
        ScoreNum = 0;
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            Debug.Log("Meg van a péz");
            if (!_collected)
            {
                Destroy(collision.gameObject);
                ScoreNum += 1;
                textCoin.text = ScoreNum.ToString();
                
            }
            



        }
        

    }

}
