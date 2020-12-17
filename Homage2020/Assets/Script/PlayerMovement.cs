using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = .1f;
    public Animator FemaleAnimator;

    // Update is called once per frame
    void Update()
    {

        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");


        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);


        transform.position += moveDirection * speed;
    } 
}

        public void PlayerAnimate()
        {
            if (Input.GetKey(KeyCode.W))
           
           {
        FemaleAnimator.SetBool("Jogging"); true);
           }
           if (Input.GetKeyUp(KeyCode.W))
           {
    FemaleAnimator.SetBool("Jogging"); false);
           }

if (Input.GetKey(KeyCode.A))
           
           {
    FemaleAnimator.SetBool("Jog Strafe Left"); true);
}
if (Input.GetKeyUp(KeyCode.A))
 {
    FemaleAnimator.SetBool("Jog Strafe Left"); false);
 }



if (Input.GetKey(KeyCode.S))
           
           {
    FemaleAnimator.SetBool("Backwards Jog"); true);
}
if (Input.GetKeyUp(KeyCode.S))
{
    FemaleAnimator.SetBool("Backwards Jog"); false);
}
 

if (Input.GetKey(KeyCode.D))

           {
    FemaleAnimator.SetBool("Jog Strafe Right"); true);
}
if (Input.GetKeyUp(KeyCode.D))
{
    FemaleAnimator.SetBool("Jog Strafe Right"); false);
}

if (Input.GetKey(KeyCode.LeftShift))

           {
    FemaleAnimator.SetBool("Running"); true);
}
if (Input.GetKeyUp(KeyCode.LeftShift))
 {
    FemaleAnimator.SetBool("Running"); false);
 }

    }

