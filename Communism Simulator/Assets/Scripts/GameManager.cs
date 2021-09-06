using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject map, endscreen;
    public Player player;
    public bool canEnd;

    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }


    void Update()
    {
        if(Input.GetKeyDown("m"))
        {
            map.SetActive(true);

        }
        else if (Input.GetKeyUp("m"))
        {
            map.SetActive(false);
        }
    }

    public void End()
    {
        player.canMove = false;
        endscreen.SetActive(true);
    }
}
