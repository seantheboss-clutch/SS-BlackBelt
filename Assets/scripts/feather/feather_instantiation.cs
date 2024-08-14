using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feather_instantiation : MonoBehaviour
{
    public int randx;
    public int randz;
    public GameObject feather;
    public bool collected;
    void Awake()
    {
        Scatter();
    }
    void Update()
    {
        if (collected)
        {
            Scatter();
        }
    }
    void Scatter()
    {
        randx = Random.Range(2000, 2200);
        randz = Random.Range(2000, 2200);
        Instantiate(feather, new Vector3(randx, 0, randz), Quaternion.identity);
    }
}
