using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_attack : MonoBehaviour
{
    private GameObject manager;
    public Transform player_t;
    private int attack_value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(attack_value > 0)
        {
            Attack(attack_value);
        }
    }
    void Attack(int a)
    {
        if (Physics.Raycast(this.transform.position, new Vector3(120, 0, 30), 100f))
        {
            manager.GetComponent<GameManager>().;
        }
    }
}
