using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineManager : MonoBehaviour
{
    private bool fix = false;
    public Animator playerAnimator;
    public RuntimeAnimatorController playerAnim;
    public PlayableDirector director;
    public Rigidbody2D rb;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void OnEnable()
    {
        playerAnim = playerAnimator.runtimeAnimatorController;
        playerAnimator.runtimeAnimatorController = null;
    }


    // Update is called once per frame
    void Update()
    {

        if (director.state == PlayState.Playing)
        {
            playerMovement._canMove = false;
            fix = true;

            


        }
        else
        {
            playerAnimator.runtimeAnimatorController = playerAnim;
            playerMovement._canMove = true;
            
        }
    }
}
