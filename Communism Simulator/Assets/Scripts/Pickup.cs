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
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Collectible>())
        {
          
            currPickup = other.gameObject;
            currPickup.GetComponentInChildren<Collectible>().canCollect = true;
        }
        else
        {
            return;
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Collectible>())
        {
            StartCoroutine(SetFalse());
        }
        else
        {
            return;
        }
    }
    IEnumerator SetFalse()
    {
        currPickup.GetComponentInChildren<Collectible>().canCollect = false;
        yield return new WaitForSeconds(0.1f);
        currPickup = null;
    }

}
