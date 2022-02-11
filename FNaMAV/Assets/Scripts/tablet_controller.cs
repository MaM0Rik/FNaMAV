using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablet_controller : MonoBehaviour
{
    public GameObject B_Tablet;
    public GameObject obj_tablet;
    public GameObject B_left;
    public GameObject B_right;
    public static int tabl = 0;

    void Update()
    {
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

    public void Button_tablet(){
        tabl += 1;
    }
}
