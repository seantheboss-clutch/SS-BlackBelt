using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun_moonrotation : MonoBehaviour
{
    public Vector3 intro_rot;
    public Quaternion intro_quat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intro_quat = Quaternion.Euler(0,90,0);
        intro_rot = new Vector3(intro_quat.x, intro_quat.y, intro_quat.z);
        this.transform.Rotate(intro_rot);
    }
}
