using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_confed : MonoBehaviour
{
    public eagle_collision e_c;
    public Vector3 which_side;
    private void OnTriggerEnter(Collider other)
    {
        //print("colliding confed");
        e_c.backTrack(which_side);
    }
}
