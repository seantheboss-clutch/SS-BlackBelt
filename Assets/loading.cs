using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loading : MonoBehaviour
{
    private Quaternion loading_q;
    public GameObject top_spinner;
    private Vector3 loading_v;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion loading_q = Quaternion.Euler(0f,90f,0f);
        loading_v = new Vector3(loading_q.x, loading_q.y, loading_q.z);
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Rigidbody>().transform.Rotate(loading_v);// loading_q.eulerAngles);
        top_spinner.GetComponent<Rigidbody>().transform.Rotate(loading_v);// loading_q.eulerAngles);
        Invoke("loaded", 10f);
    }
    void loaded()
    {
        SceneManager.LoadScene(8);
    }
}
