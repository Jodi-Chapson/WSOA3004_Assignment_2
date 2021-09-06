using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    
   public int woodNum = 0;
    public int stoneNum = 0;
    public int woodmax, stonemax;
    public Text wood, stone;
    public float collectionDistance;
    public GameObject woodstrike, stonestrike;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        woodNum = 0;
        stoneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        wood.text = woodNum + "/" + woodmax;
        stone.text = stoneNum + "/" + stonemax;

        if (woodNum >= woodmax)
        {
            if (woodstrike.activeSelf == false)
            {
                woodstrike.SetActive(true);
            }
        }


     
        if (stoneNum >= stonemax)
        {
            if (stonestrike.activeSelf == false)
            {
                stonestrike.SetActive(true);
            }
        }


        if (woodstrike.activeSelf == true && stonestrike.activeSelf == true)
        {
            manager.canEnd = true;
        }

    }
}
