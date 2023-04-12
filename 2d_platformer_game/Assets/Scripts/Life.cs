using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public void GoToMenu() => SceneManager.LoadScene("Menuscene");

    public static int fullLife;

    public int tfl = fullLife;

    public TextMeshProUGUI textmesh;

    public GameObject gameover;

    //private bool halal = false;

    private bool isHalal = false;

    void Start()
    {
        if (PlayerPrefs.GetInt("FullLife") > 0 )
        {
            fullLife = PlayerPrefs.GetInt("FullLife");
        }
        else
        {
            fullLife = 4;
        }
        
        gameover.SetActive(false);
    }

    void lifeup()
    {
        isHalal = false;
        PlayerPrefs.DeleteAll();
        fullLife = 4;
    }

    void Update()
    {
        textmesh.text = fullLife.ToString();

        if (fullLife == 0)
        {
            isHalal = true;
        }

        if (isHalal)
        {
            
            Debug.Log("GameOver");
            gameover.SetActive(true);
            FindObjectOfType<AudioManager>().Stop("JatekTheme");
            FindObjectOfType<AudioManager>().Play("OverSound");
            Invoke("lifeup", 1f);
           

        }

    }
}
