using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luke_controller : MonoBehaviour
{
    public int Luke_status = 0;
    public GameObject Luke_obj;

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

        }
        if(Luke_status == 2){
            Luke_status = 0;
        }
        if(Luke_status == 0){

        }
        
    }
}
