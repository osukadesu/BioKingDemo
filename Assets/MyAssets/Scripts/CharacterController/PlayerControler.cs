using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    public CharacterController characterController;
    private float gravityModifier = 2f;
    private Vector3 moveInput;
    public Transform camTransform;
    private float mousesensitivity = 6f;
    void Start()
    {

    }
    void Update()
    {
        MoveXY();
        RotationCam();
    }
    void MoveXY()
    {
        float yStore = moveInput.y;
        Vector3 verticalmove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalmove = transform.right * Input.GetAxis("Horizontal");
        moveInput = horizontalmove + verticalmove;
        moveInput.Normalize();
        moveInput = moveInput * moveSpeed;
        moveInput.y = yStore;
        moveInput.y += Physics.gravity.y * gravityModifier * Time.deltaTime;
        if (characterController.isGrounded)
        {
            moveInput.y = Physics.gravity.y * gravityModifier * Time.deltaTime;
        }
        characterController.Move(moveInput * Time.deltaTime);

    }
    void RotationCam()
    {
        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mousesensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
        camTransform.rotation = Quaternion.Euler(camTransform.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));
    }
}
