using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int feather_count;
    public bool got;
    public bool buy;
    // Update is called once per frame
    void Update()
    {
        if(got)
        {
            feather_count++;
        }
        if(buy)
        {
            feather_count--;
        }
    }
}
