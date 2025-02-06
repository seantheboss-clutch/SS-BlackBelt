using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_puppet_journal : MonoBehaviour
{
    public GameObject puppet_journal;
    // Start is called before the first frame update
    void Start()
    {
        puppet_journal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        puppet_journal.transform.position = new Vector3(this.transform.position.x-30, this.transform.position.y, this.transform.position.z - 20);
    }
}
