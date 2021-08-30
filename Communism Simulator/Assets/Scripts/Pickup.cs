using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    [SerializeField]
    GameObject currPickup;
    [SerializeField]
    Material selected;
    [SerializeField]
    Material deselected;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currPickup != null)
            {
                currPickup.GetComponent<Collectible>().CollectResource();
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Collectible>())
        {
          
            currPickup = other.gameObject;
            currPickup.GetComponentInChildren<Renderer>().material = selected;
        }
        else
        {
            currPickup.GetComponentInChildren<Renderer>().material = deselected;
            currPickup = null;
          
        }
    }
    private void OnTriggerExit(Collider other)
    {
        currPickup.GetComponentInChildren<Renderer>().material = deselected;
        currPickup = null;
       
        
      
    }


}
