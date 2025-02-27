using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eagle_move : MonoBehaviour
{
    public player_attack p_a;
    public eagle_rotation e_r;
    private bool test;
    public bool eagle_not_alerted;
    public Rigidbody eagle_rb;
    public int eagle_distance;
    public Vector3 eagle_start;
    public int eagle_speed;
    public GameObject player;
    public bool eagle_not_engaged;
    public bool bumped;
    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = eagle_start;
        eagle_not_alerted = true;
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            if (eagle_rb.velocity.y <= 0)
            {
                eagle_rb.useGravity = false;
                //Invoke("gravity_check", 1f);
            }
            if (eagle_not_alerted)
            {
                if (eagle_not_engaged)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 300, this.transform.position.z);
                    e_r.eagle_test_rot = new Vector3(0, 67, 0);
                    e_r.Eagle_Rotation();
                    eagle_start = this.transform.position;
                    eagle_not_engaged = false;
                }
                if (Vector3.Distance(this.transform.position, eagle_start) >= eagle_distance || this.transform.position.y > 400 || bumped)
                {

                    e_r.eagle_test_rot = new Vector3(Random.Range(-120f, 120f), Random.Range(-120f, 120f), 0f);
                    randomEncounter();
                    if (e_r.eagle_test_rot.y == 0)
                    {
                        e_r.eagle_test_rot.y = 120;
                    }
                    e_r.Eagle_Rotation();
                    //eagle_speed += 1;
                    eagle_rb.velocity = transform.TransformDirection(Vector3.right * eagle_speed);
                    if (bumped)
                    {
                        bumped = false;
                    }
                }
                else
                {
                    eagle_rb.velocity = transform.TransformDirection(Vector3.right * eagle_speed);
                }

            }
            else
            {
                eagle_rb.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 15f, player.transform.position.z + 30f);
                p_a.times_eagle_attacked += 1;
            }
        }
    }
    void gravity_check()
    {
        eagle_rb.useGravity = true;
    }
    void randomEncounter()
    {
        rand = Random.Range(0, 10);
        print(rand+" where the flip is randall");
    }
   
}
