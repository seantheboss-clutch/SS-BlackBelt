using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class well_assignment : MonoBehaviour
{
    public GameObject well1;
    public GameObject well2;
    public GameObject well3;
    public GameObject well4;
    public GameObject dead_well;
    //Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(1, 4);

        switch(random)
        {
            case 1:
                dead_well = well1;
                break;
            case 2:
                dead_well = well2;
                break;
            case 3:
                dead_well = well3;
                break;
            case 4:
                dead_well = well4;
                break;
        }
    }
}
