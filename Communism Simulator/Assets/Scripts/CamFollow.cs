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
    public float verticalMod = 0.1f;
   
    public void Start()
    {
        startPos = this.transform.position;
    }

    public void Update()
    {
        if (camFollow)
        {
            Vector3 target = new Vector3(targetplayer.transform.position.x + startPos.x + verticalMod, this.transform.position.y, targetplayer.transform.position.z + startPos.z + verticalMod);
            

            this.transform.position = target;

        }
    }

}
