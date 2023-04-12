using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirector;

    public void Play(float time)
    {
        playableDirector.time = time;
        SceneManager.LoadScene("jatek");
    }
}
