using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main_Camera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);
        mouseX = Mathf.Clamp(mouseX, 90f, 270f);
    }
}
