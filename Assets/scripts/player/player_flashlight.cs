using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_flashlight : MonoBehaviour
{
    public bool has_light;
    public GameObject plot1;
    public GameObject plot2;
    public GameObject plot3;

    void Update()
    {
        if (has_light)
        {
            Physics.Raycast(Vector3.forward, Vector3.forward, out RaycastHit hit, 800f, 2);
            switch(hit.collider.gameObject.name)
            {
                case "plot1":
                    Instantiate(plot1, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 10), Quaternion.identity);
                    break;
                case "plot2":
                    Instantiate(plot2, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 10), Quaternion.identity);
                    break;
                case "plot3":
                    Instantiate(plot3, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 10), Quaternion.identity);
                    break;
            }
        }
    }
}
