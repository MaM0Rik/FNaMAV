using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Transform PlayerBody;

    public GameObject B_left;
    public GameObject B_right;
    public GameObject B_camera_up;

    public GameObject Flashlight;
    public GameObject obj_tablet;
    public GameObject Luke;
    
    public float RotationSpeed = 8f;

    public AudioSource flashlightAudeo;
    public int R = 1;
    public int L = 0;
    public int tabl = 0;

    void Update() {
    ///Debug.Log(R);

        if(R == 2){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.AngleAxis(-90, Vector3.up), RotationSpeed * Time.deltaTime);
            B_camera_up.SetActive(false);
            B_left.SetActive(false);
            B_right.SetActive(true);

            Flashlight.SetActive(false);

        }

        if(R == 0){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.AngleAxis(90, Vector3.up), RotationSpeed *Time.deltaTime);
            B_left.SetActive(true);
            B_right.SetActive(false);
            B_camera_up.SetActive(false);

            Flashlight.SetActive(true);
            ///flashlightAudeo.Play();
        }

        if(R == 1){
            PlayerBody.transform.rotation = Quaternion.Lerp(PlayerBody.transform.rotation, Quaternion.AngleAxis(0, Vector3.up), RotationSpeed * Time.deltaTime);
            B_camera_up.SetActive(true);

            Flashlight.SetActive(false);
            
            if(tabl == 0){
                obj_tablet.SetActive(false);
                B_left.SetActive(true);
                B_right.SetActive(true);
        }
            if(tabl == 1){
                obj_tablet.SetActive(true);
                B_left.SetActive(false);
                B_right.SetActive(false);
        }
            if(tabl == 2){
                tabl = 0;
        }
            
        }
    }

    public void Button_left(){
        R += 1;
    }

    public void Button_right(){
        R -= 1;
    }

    public void Button_tablet(){
        tabl += 1;
    }
}
