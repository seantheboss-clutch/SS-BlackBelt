using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_rotation : MonoBehaviour
{
    public eagle_move e_m;
    public Vector3 eagle_test_rot = new Vector3(0, 0, 0);
    public Quaternion eagle_quat;
    public Vector3 eagle_rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Eagle_Rotation()
    {
        eagle_quat = Quaternion.Euler(eagle_test_rot.x,eagle_test_rot.y,eagle_test_rot.z);
        //eagle_rot = new Vector3(eagle_quat.x, eagle_quat.y, eagle_quat.z);
        e_m.eagle_rb.transform.Rotate(eagle_quat.eulerAngles);
    }
}
