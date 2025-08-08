using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class transition_object_instruction : MonoBehaviour
{
    public Slider[] sliders;
    public int slide_chosen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        hasslid(0);
        hasslid(1);
        hasslid(2);
    }
    void hasslid(int index)
    {
        if (sliders[index].value >= 1)
        {
            slide_chosen = index;
            checkSlider(slide_chosen);
        }
    }    
    void checkSlider(int slider)
    {
        switch(slide_chosen)
        {
            case 0:
                PlayerPrefs.SetString("nextscene", "game");
                break;
            case 1:
                PlayerPrefs.SetString("nextscene", "store");
                break;
            case 2:
                PlayerPrefs.SetString("nextscene", "instructions");
                break;
        }
        SceneManager.LoadScene(8);
    }
}
