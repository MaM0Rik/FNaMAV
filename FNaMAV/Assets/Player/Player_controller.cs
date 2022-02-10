using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Transform PlayerBody;
    public GameObject B_left;
    public GameObject B_right;
    public GameObject B_camera_up;
    public GameObject Tablet;
    public int R = 1;
    public int C = 0;

    void Update() {
        if(R == 2){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime);
            B_camera_up.SetActive(false);
            B_left.SetActive(false);
            B_right.SetActive(true);
        }

        if(R == 0){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime);
            B_left.SetActive(true);
            B_right.SetActive(false);
            B_camera_up.SetActive(false);
        }
        if(R == 1){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.Euler(0, 00, 0), Time.deltaTime);
            B_left.SetActive(true);
            B_right.SetActive(true);
            B_camera_up.SetActive(true);
            if(C == 0){
                Tablet.SetActive(false);
                B_left.SetActive(true);
                B_right.SetActive(true);
            }
            if(C == 1){
                Tablet.SetActive(true);
                B_left.SetActive(false);
                B_right.SetActive(false);
            }
            if(C == 2){
                C = 0;
            }
        }
    }

    public void Button_left(){
        R += 1;
    }

    public void Button_right(){
        R -= 1;
    }
    public void Button_camera_up(){
        C += 1;
    }
}
