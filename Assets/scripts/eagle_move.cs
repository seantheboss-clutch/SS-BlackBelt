using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_move : MonoBehaviour
{
    public bool eagle_not_alerted;
    public Rigidbody eagle_rb;
    public int eagle_distance;
    public Vector3 eagle_start;
    public int eagle_speed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = eagle_start;
        eagle_not_alerted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(eagle_not_alerted)
        {
            if (this.transform.position.y - eagle_start.y >= eagle_distance)
            {
                this.transform.position = eagle_start;
            }
            else
            {
                eagle_rb.transform.TransformDirection(Vector3.forward*eagle_speed);
            }
        }
    }
}
