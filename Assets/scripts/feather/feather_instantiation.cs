using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feather_instantiation : MonoBehaviour
{
    public int randx;
    public int randz;
    public GameObject feather;
    public GameObject old_feather;
    public bool collected;
    void Awake()
    {
        Scatter(true);
    }
    void Update()
    {
        if (collected)
        {
            Scatter(false);
            collected = false;
        }
    }
    void Scatter(bool start)
    {
        randx = Random.Range(3000, 5000);
        randz = Random.Range(3000, 5000);
        if(start == false)
        {
            old_feather = feather;
            old_feather.SetActive(false);
        }
        feather = Instantiate(feather,new Vector3(randx, 3000, randz),Quaternion.identity);
        feather.SetActive(true);
    }
}
