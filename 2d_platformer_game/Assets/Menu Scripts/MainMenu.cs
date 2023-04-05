using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject noSave;
    public void PlayTheGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("CutScene");
    }
      

    public void OptionsMenu() => SceneManager.LoadScene("Scenes/OptionsScene");

    public void QuitTheGame() => Application.Quit();

    public void Start()
    {
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


}
