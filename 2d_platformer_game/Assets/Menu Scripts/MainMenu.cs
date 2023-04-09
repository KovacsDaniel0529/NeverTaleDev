using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    public GameObject noSave;

    //Button functions

    public void PlayTheGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("CutScene");
    }

    public void QuitTheGame() => Application.Quit();

    public void ClickedButton() => FindObjectOfType<AudioManager>().Play("ButtonClick");


    //Functions

    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("MenuTheme");
        noSave.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("kivantöröve");
        }
    }

    public void LoadGame()
    {
        if(PlayerPrefs.HasKey("PlayerX") == false)
        {
            noSave.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("jatek");
        }


    }

    // Options Menu

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }


}
