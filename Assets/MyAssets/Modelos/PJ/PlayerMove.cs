using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speedmove = 15f, speedrotation = 200f;
    private float inputy = 0f, inputz = 0f;
    [SerializeField] private Animator anim;
    [SerializeField] private ManagerJoystick managerJoystick;
    void Update()
    {
        /*
            inputy = Input.GetAxis("Horizontal");
            inputz = Input.GetAxis("Vertical");
        */
        inputy = managerJoystick.inputHorizontal();
        inputz = managerJoystick.inputVertical();

        transform.Rotate(0, inputy * Time.deltaTime * speedrotation, 0);
        transform.Translate(0, 0, inputz * Time.deltaTime * speedmove);
        if (inputy != 0f || inputz != 0f)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}
