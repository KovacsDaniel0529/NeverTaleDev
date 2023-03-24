using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Knight;


    public void Kill()
    {
        GetComponent<IsDamageByEnemy>().enabled = false;
        Destroy(Knight);
    }
}
    

