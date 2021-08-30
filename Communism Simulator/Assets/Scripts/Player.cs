using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float movespeed = 3f;
    public float speedMod = 0.5f;

    Vector3 forward, right;

    public void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);


        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    public void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }
    }

    public void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMove;
        Vector3 upMove;

        if (direction.x != 0 && direction.z != 0)
        {
            //character is going diagonal
            rightMove = right * movespeed * speedMod * Time.deltaTime * Input.GetAxis("HorizontalKey");
            upMove = forward * movespeed * speedMod * Time.deltaTime * Input.GetAxis("VerticalKey");
        }
        else
        {
            rightMove = right * movespeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
            upMove = forward * movespeed * Time.deltaTime * Input.GetAxis("VerticalKey");
        }

        

        Vector3 heading = Vector3.Normalize(rightMove + upMove);
        
        //rotates character
        transform.forward = heading;
        //moves character
        transform.position += rightMove;
        transform.position += upMove;
    }


}
