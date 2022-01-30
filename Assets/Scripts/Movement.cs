using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public float horizontalSpeed = 5f;
    public float verticalSpeed = 5f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 horizontalMove = Vector3.right * horizontalInput * horizontalSpeed;
        Vector3 verticalMove = Vector3.forward * verticalInput * verticalSpeed;
        controller.Move((horizontalMove + verticalMove) * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}
