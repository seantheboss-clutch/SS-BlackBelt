using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friend_collision : MonoBehaviour
{
    public GameManager g_m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(this.gameObject.CompareTag("village"))
        {
            g_m.feather_count = 10;
            g_m.end_game = true;
            g_m.destination = true;
        }
    }
}
