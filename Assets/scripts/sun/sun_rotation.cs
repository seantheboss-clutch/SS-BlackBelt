using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun_rotation : MonoBehaviour
{
    public Quaternion sq;
    public Vector3 sv;
    public Light sun;
    public float sun_speed;
    public int sun_count;
    
    void Start()
    {
        start_mid_up_rot(0);
    }

    
    void Update()
    {
        start_mid_up_rot(sun_speed);
    }
    void start_mid_up_rot(float x)
    {
        sq = Quaternion.Euler(x, 0, 0);
        sv = new Vector3(sq.x, 0, 0);
        sun.transform.Rotate(sv);
    }
}
