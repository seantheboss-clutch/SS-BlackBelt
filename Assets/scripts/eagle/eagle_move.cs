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
    public GameObject player;
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
            if (this.transform.position.z - eagle_start.z >= eagle_distance)
            {
                this.transform.position = new Vector3(eagle_start.x, eagle_start.y-100f, eagle_start.z);
            }
            else
            {
                eagle_rb.velocity = transform.TransformDirection(Vector3.right*eagle_speed);
            }
        }
        else
        {
            eagle_rb.transform.position = new Vector3(player.transform.position.x + 40, player.transform.position.y + 20, player.transform.position.z + 20);
        }
    }
}
