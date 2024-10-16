using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_collision : MonoBehaviour
{
    public LayerMask terrain;
    public eagle_rotation e_r;
    public bool just_bumped_beak = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(this.transform.position, Vector3.forward, 50f, terrain))
        {
            e_r.eagle_test_rot = new Vector3(90, 0, 0);
            e_r.Eagle_Rotation();
            just_bumped_beak = true;
        }
        else
        {
            if(just_bumped_beak)
            {
                e_r.eagle_test_rot = new Vector3(-90,0,0);
                e_r.Eagle_Rotation();
            }
        }
    }
}
