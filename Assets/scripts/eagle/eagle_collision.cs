using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_collision : MonoBehaviour
{
    public eagle_rotation e_r;
    public eagle_move e_m;
    public Vector3 v = Vector3.right;
    public void backTrack(Vector3 side)
    {
        e_m.eagle_rb.velocity = transform.TransformDirection(side * e_m.eagle_speed);
        e_m.bumped = true;
    }

}
