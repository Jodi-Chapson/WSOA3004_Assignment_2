using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject map;

    // Update is called once per frame
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
}
