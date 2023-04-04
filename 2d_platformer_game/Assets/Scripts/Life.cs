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
        gameover.SetActive(false);
    }

    void lifeup()
    {
        isHalal = false;
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
            lifeup();
           
        }
    }
}
