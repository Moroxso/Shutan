using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    public float mouseSensitivity = 100f;
    private float xRotation = 44f;
    private float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        MovementCameraWithMouse();
    }


    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * 10f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(Vector3.back * Time.deltaTime * 10f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(Vector3.left * Time.deltaTime * 10f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(Vector3.right * Time.deltaTime * 10f);
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (player.transform.position.y < 4) {
                player.transform.Translate(Vector3.up / (Time.deltaTime / 0.01f));
            }
        }
    }

    private void MovementCameraWithMouse()
    {

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime * 10f;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime * 10f;


            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, 0f, 0f);

            player.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        
    }



}
