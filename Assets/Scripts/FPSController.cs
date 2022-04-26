using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform cameraTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xDelta = Input.GetAxis("Mouse X"); // moving mouse left-right
        float yDelta = Input.GetAxis("Mouse Y"); // moving mouse up-down

        playerTransform.Rotate(Vector3.up, xDelta);
        cameraTransform.Rotate(Vector3.right, -yDelta);
    }
}
