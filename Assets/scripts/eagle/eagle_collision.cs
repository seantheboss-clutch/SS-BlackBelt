using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_collision : MonoBehaviour
{
    public LayerMask terrain;
    public eagle_rotation e_r;
    public bool just_bumped_beak = false;
    public bool tried_moving_away = false;
    public bool forward = false;
    public bool back = false;
    public bool down = false;
    public eagle_move e_m;

    void Update()
    {
        if(forward)
        {
            eagle_vertical_rotation(Vector3.forward);
            print("FORWARD!!!");
        } else if(Physics.Raycast(this.transform.position, Vector3.back, 5f, terrain))
        {
            eagle_vertical_rotation(Vector3.back);
        } else if (Physics.Raycast(this.transform.position, Vector3.down, 5f, terrain))
        {
            eagle_vertical_rotation(Vector3.down);
            print("You'll find me in the club, bottle full of bud, my mind got what you need...");
        }
    }
    void eagle_vertical_rotation(Vector3 collide_direction)
    {
        if(collide_direction == Vector3.down)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 50f, this.transform.position.z);
            e_r.eagle_test_rot = new Vector3(-90f, 0, 0);
            e_r.Eagle_Rotation();
        }
        int angle_of_eagle_oops = 1;
        if(collide_direction == Vector3.forward)
        {
            angle_of_eagle_oops *= -1;
        }
        int eagle_vector_oops = angle_of_eagle_oops * 10;
            
        if (Physics.Raycast(this.transform.position, collide_direction, 50f, terrain))
        {
            if (tried_moving_away)
            {
                e_r.eagle_test_rot = new Vector3(90, 0, 0);
                e_r.Eagle_Rotation();
                just_bumped_beak = true;
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + eagle_vector_oops, this.transform.position.z + eagle_vector_oops);
                e_m.oops = true;
                tried_moving_away = true;
            }
        }
        else
        {
            if (just_bumped_beak)
            {
                this.transform.Rotate(new Vector3(-90, 0, 0));
               
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(Physics.Raycast(this.transform.position, Vector3.forward, 5f, terrain))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 50f);
            forward = true;
        }
        if (Physics.Raycast(this.transform.position, Vector3.back, 5f, terrain))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 50f);
            back = true;
        }
        if (Physics.Raycast(this.transform.position, Vector3.down, 5f, terrain))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+50f, this.transform.position.z);
            down = true;
        }
    }
}
