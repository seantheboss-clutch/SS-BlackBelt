using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Slider s_beginning;
    public int scene_index;

    void Start()
    {
        s_beginning.value = 0;
    }

    
    void Update()
    {
        if (s_beginning.value >= 1)
        {
            SceneManager.LoadScene(scene_index);
        }
    }
}
