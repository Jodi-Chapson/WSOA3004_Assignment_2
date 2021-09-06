using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [Header("References")]
    public GameObject targetplayer;

    [Header("States")]
    public bool camFollow;

    [Header("Stats")]
    public Vector3 startPos;
    public float ymod;
    public float xmod;
    public float zmod;


    public bool canTurn = true;
    public void Start()
    {
        startPos = this.transform.position;
    }

    public void Update()
    {
        if (camFollow)
        {
            Vector3 target = new Vector3(targetplayer.transform.position.x + xmod, startPos.y + ymod, targetplayer.transform.position.z + zmod);
            

            this.transform.position = target;

            
            }
        }

    

}
