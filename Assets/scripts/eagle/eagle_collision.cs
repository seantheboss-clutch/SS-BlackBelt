using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_collision : MonoBehaviour
{
    public eagle_rotation e_r;
    public eagle_move e_m;
    public string collide_side = "";

    void Update()
    {
        switch(collide_side)
        {
            case "front":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.left*e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            case "back":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.right * e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            case "left":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.forward * e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            case "right":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.back * e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            case "top":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.down * e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            case "bottom":
                e_m.eagle_rb.velocity = transform.TransformDirection(Vector3.up * e_m.eagle_speed);
                e_m.bumped = true;
                print(collide_side);
                break;
            default:
                print($"Failed: {collide_side}");
                break;
        }
    }
   
}
