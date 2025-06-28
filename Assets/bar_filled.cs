using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bar_filled : MonoBehaviour
{
    public Vector3 start_pos_bar = new Vector3(-601,495,223);
    public Rigidbody bar_rb;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = start_pos_bar;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x+.1f,this.transform.position.y, this.transform.position.z);
        if(Vector3.Distance(start_pos_bar,this.transform.position) >= 301)
        {
            SceneManager.LoadScene(8);
        }
    }
}
