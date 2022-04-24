using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luke_controller : MonoBehaviour
{
    public int Luke_status = 0;
    public GameObject Luke_obj;
    public float speed = 0.1f;
    public Transform a_point;
    public Transform b_point;

    void Update()
    {
        if(Player_controller.R == 1){

        }

        if(Player_controller.R == 0){
            if(Input.GetKeyDown(KeyCode.LeftShift)){
                Luke_status += 1; 
            }
        }

        if(Luke_status == 1){
            Luke_obj.transform.position = Vector3.Lerp(a_point.position, b_point.position, speed);
        }
        if(Luke_status == 2){
            Luke_status = 0;
        }
        if(Luke_status == 0){
            Luke_obj.transform.position = Vector3.Lerp(b_point.position, a_point.position, speed);
        }
        
    }
}
