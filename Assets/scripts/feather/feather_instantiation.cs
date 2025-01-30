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
        randx = Random.Range(1828, 2488);
        randz = Random.Range(1285, 2340);
        if(start == false)
        {
            old_feather = feather;
            old_feather.SetActive(false);
        }
        feather = Instantiate(feather,new Vector3(randx, 100, randz),Quaternion.identity);
        feather.SetActive(true);
    }
}
