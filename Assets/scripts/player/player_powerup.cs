using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_powerup : MonoBehaviour
{
    public GameObject game_manager;
    public string powerup;
    void Update()
    {
        switch (powerup)
        {
            case "water":
                game_manager.GetComponent<GameManager>().water_obtained = true;
                break;
            case "hook":
                this.GetComponent<player_move>().climb = true;
                Invoke("Turn_off_hook", 8f);
                break;
            case "light":
                this.GetComponent<player_flashlight>().has_light = true;
                Invoke("Turn_off_light", 8f);
                break;
        }
    }
    void Turn_off_light()
    {
        this.GetComponent<player_flashlight>().has_light = false;
    }
    void Turn_off_hook()
    {
        this.GetComponent<player_move>().climb = false;

    }
}
