using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    
   public int woodNum = 0;
    public int stoneNum = 0;
    public Text wood, stone;
    public float collectionDistance;
    // Start is called before the first frame update
    void Start()
    {
        woodNum = 0;
        stoneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        wood.text = woodNum + "/6";
        stone.text = stoneNum + "/4";
        
    }
}
