using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public void GoToMenu() => SceneManager.LoadScene("Menuscene");

    public static int fullLife = 4;

    public TextMeshProUGUI textmesh;

    public GameObject gameover;

    //private bool halal = false;

    private bool isHalal;

    void Start()
    {
        Time.timeScale = 1f;
        gameover.SetActive(false);
    }
    void delay()
    {
        Time.timeScale = 0f;
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
            isHalal = false;
            Debug.Log("GameOver");
            gameover.SetActive(true);
            Invoke("delay", 4f);
        }
    }
}
