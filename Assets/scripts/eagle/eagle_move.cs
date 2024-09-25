using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (eagle_not_alerted)
        {
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
            while (Vector3.Distance(this.transform.position, player.transform.position) > 25f)
            {
                eagle_rb.velocity = transform.TransformDirection(Vector3.down * 5);
            
            }
            if(Vector3.Distance(this.transform.position, player.transform.position) < 1f)
            {
                print("you died");
                //SceneManager.LoadScene()
            } 
                
            eagle_rb.velocity = transform.TransformDirection(new Vector3(player.transform.position.x-this.transform.position.x,player.transform.position.y-this.transform.position.y,20f)*eagle_speed);      
        }
    }
   
}
