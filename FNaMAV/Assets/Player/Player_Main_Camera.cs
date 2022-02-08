using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main_Camera : MonoBehaviour
{
    public CharacterController controller;
    public float Rotate_speed;
    public GameObject B_rotation_left;
    public GameObject B_rotation_right;
    public int a = 2;

    void FixedUpdate() {
        Debug.Log(a);
        if (a == 1){
            B_rotation_left.SetActive(true);
            B_rotation_right.SetActive(false);
        }
        if (a == 2){
            B_rotation_left.SetActive(true);
            B_rotation_right.SetActive(true);
        }
        if (a == 3){
            B_rotation_left.SetActive(false);
            B_rotation_right.SetActive(true);
        }
    }

    public void Start() {
        B_rotation_left.SetActive(true);
        B_rotation_right.SetActive(true);
    }

    public void rotation_left(){
        a -= 1;
    }

    public void rotation_right(){
        a += 1;
    }
}
