using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    int resourceNumber;
    ResourceManager rm;
    public bool canCollect;
    private void Start()
    {
        rm = GameObject.Find("ResourceManager").GetComponent<ResourceManager>();
    }
   

    public void CollectResource()
    {
        rm.woodNum += resourceNumber;
        Debug.Log(this.gameObject.tag);
        Destroy(gameObject);
    }
    private void OnMouseOver()
    {
        
    }
    private void OnMouseDown()
    {
        if (canCollect)
        {
            CollectResource();
        }
        
    }
}
