using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eagle_move : MonoBehaviour
{
    public player_attack p_a;
    public eagle_rotation e_r;
    public bool eagle_not_alerted;
    public Rigidbody eagle_rb;
    public int eagle_distance;
    public Vector3 eagle_start;
    public int eagle_speed;
    public GameObject player;
    public bool eagle_not_engaged;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = eagle_start;
        eagle_not_alerted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (eagle_not_alerted)
        {
            if (eagle_not_engaged)
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 200, this.transform.position.z);
                e_r.eagle_test_rot = new Vector3(0, -90, 0);
                eagle_start = this.transform.position;
                eagle_not_engaged = false;
            }
            if (this.transform.position.z - eagle_start.z >= eagle_distance)
            {
                this.transform.position = new Vector3(eagle_start.x, eagle_start.y - 100f, eagle_start.z);
            }
            else
            {
                eagle_rb.velocity = transform.TransformDirection(Vector3.right * eagle_speed);
            }

        }
        else
        {
            if(Vector3.Distance(this.transform.position, player.transform.position) < 1f)
            {
                print("you died");
                //SceneManager.LoadScene()
            } 
                
            eagle_rb.transform.position = new Vector3(player.transform.position.x,player.transform.position.y+15f,player.transform.position.z+30f);
            p_a.times_eagle_attacked += 1;
        }
    }
   
}
