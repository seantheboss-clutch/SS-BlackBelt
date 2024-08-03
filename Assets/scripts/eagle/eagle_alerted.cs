using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_alerted : MonoBehaviour
{
    public Rigidbody eagle_rb;
    public GameObject player;
    public GameObject eagle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(this.transform.position, Vector3.down, 3))
        {
            eagle.GetComponent<eagle_move>().eagle_not_alerted = false;
        }
    }
}
