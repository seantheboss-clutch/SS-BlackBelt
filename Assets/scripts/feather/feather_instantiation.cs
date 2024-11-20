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
            collected = false;
            feather.SetActive(false);
        }
    }
    void Scatter()
    {
        randx = Random.Range(1500, 2500);
        randz = Random.Range(1500, 2500);
        Instantiate(feather,new Vector3(randx, 3000, randz),Quaternion.identity);
    }
}
