using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skip_button : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(skip);
    }
    // Update is called once per frame
    void skip()
    {
        SceneManager.LoadScene(7);
    }
}
