using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayTheGame() => SceneManager.LoadScene("CutScene");

    public void OptionsMenu() => SceneManager.LoadScene("Scenes/OptionsScene");

    public void QuitTheGame() => Application.Quit(); 

}
