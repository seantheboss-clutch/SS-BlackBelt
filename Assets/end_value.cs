using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class end_value : MonoBehaviour
{
    public Text[] end_text;
    // Start is called before the first frame update
    void Start()
    {
        
        end_text[0].text = $"FINAL SCORE: {PlayerPrefs.GetFloat("Final Score").ToString()}";
        end_text[1].text = $"HIGH SCORE: {PlayerPrefs.GetFloat("High Score").ToString()}";
    }

    
    void Update()
    {
        
    }
}
