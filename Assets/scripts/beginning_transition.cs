using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Slider s_beginning;
    public Slider s_back;
    public int scene_index;
  

    void Start()
    {
        s_beginning.value = 0;
        if(s_back != null)
        s_back.value = 0;
    }

    
    void Update()
    {
        if (s_beginning.value >= 1)
        {
            SceneManager.LoadScene(scene_index);
        }
        if(s_back != null)
        if (s_back.value >= 1)
        {
            SceneManager.LoadScene(scene_index-2);
        }

    }
}
