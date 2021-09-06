using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    int resourcetype; //0 is wood, 1 is stone
    ResourceManager rm;
    Transform player;
    public bool canCollect;
    
    private void Start()
    {
        rm = GameObject.Find("ResourceManager").GetComponent<ResourceManager>();
        player = GameObject.Find("Player").transform;
    }
   

    public void CollectResource()
    {
        if (resourcetype == 0)
        {
            rm.woodNum++;
        }
        else if (resourcetype == 1)
        {
            rm.stoneNum++;
        }
        
        
        
        Destroy(gameObject);
    }


    private void OnMouseOver()
    {
        
    }
    private void OnMouseDown()
    {
        if (canCollect)
        {
            Debug.Log(Vector3.Distance(this.transform.position, player.position));

            if (Vector3.Distance(this.transform.position, player.position) < rm.collectionDistance)
            {

                CollectResource();
            }
        }
        
    }
}
