using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_rotation : MonoBehaviour
{
    private Vector3 player_rot;
    private Quaternion player_quat;
    public int rot;
    void Update()
    {
        if (Input.GetKey("a"))
        {
            player_quat = Quaternion.Euler(0, -rot, 0);
            player_rot = new Vector3(0, player_quat.y, 0);
            this.transform.Rotate(player_rot);
        }
        if (Input.GetKey("d"))
        {
            player_quat = Quaternion.Euler(0, rot, 0);
            player_rot = new Vector3(0, player_quat.y, 0);
            this.transform.Rotate(player_rot);
        }
    }
}
