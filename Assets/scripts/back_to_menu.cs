using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class back_to_menu : MonoBehaviour
{
    public Button restart_button;
    // Start is called before the first frame update
    void Start()
    {
        restart_button.onClick.AddListener(restart);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void restart()
    {
        SceneManager.LoadScene(0);
    }
}
