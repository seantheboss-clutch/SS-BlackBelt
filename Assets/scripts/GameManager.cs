using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("feathers")]
    public int feather_count;


    [Header("store")]
    public bool got;
    public bool buy;
    public int debit_to_check;
    public int transaction;
    public GameObject store;

    [Header("water")]
    public int water_count;
    public bool water_obtained;
    public int water_casualty;

    public GameObject player;
    public bool player_touched_well;
    public bool end_game;
    public bool destination;
    public sun_rotation s_r;
    public GameObject endgameobject;
    

    [Header("stuff for end of game")]
    public Animator endgame;
    public GameObject lose;
    public GameObject win;
    public int final_score;
    public Text final_score_text;

    [Header("Sliders")]
    public Slider water_slider;
    public Slider feather_slider;
    public Slider time_slider;


    [Header("journals")]

    public string[] journal_secrets = {"I","'","M","I","N","N","E","S","T"};
    public Text[] secret_text = {};
    public bool revelation;
    // Update is called once per fr
    // ame
    void Start()
    {
        endgameobject.SetActive(false);
        destination = false;
        water_count = 5;
        feather_count = 5;
        feather_slider.value = feather_count;
        water_slider.value = water_count;
        print(feather_count);
        for(int i = 0; i < secret_text.Length; i++)
        {
            secret_text[i].text = "_"; //SetValue("_", i);
        }
        final_score_text.text = "";
    }
    void Update()
    {
        print(feather_slider.value+"swag");
        if (end_game == false)
        {
            if (got & feather_count <= 10)
            {
                feather_count++;
                got = false;
            }
            if (buy)
            {
                Debit(transaction);
                buy = false;
            }
            if (water_obtained & water_count <= 10)
            {
                water_count += 10;
            }
            if (player_touched_well)
            {
                water_count += 5;
                player_touched_well = false;
            }
            if(water_casualty > 0)
            {
                Casualty(water_casualty);
                if(water_count < 1)
                {
                    Lose();
                }
            }
            water_slider.value = water_count;
            feather_slider.value = feather_count;

            if (revelation)
            {
                Reveal();
                revelation = false;
            }

            
        }
        else
        {
            if (destination)
            {
                Win();
            }
            else if (destination == false)
            {
                Lose();
            }
        }

    }
    void Debit(int transact)
    {
        feather_count -= transact;
    }
    void Casualty(int casualty)
    {
        water_count -= casualty;
        water_casualty = 0;
    }
    void Reveal()
    {
        int secret_to_reveal_index = Random.Range(0, secret_text.Length - 1);
        secret_text[secret_to_reveal_index].text = journal_secrets[secret_to_reveal_index];
    }
    public void Win()
    {
        endgameobject.SetActive(true);
        lose.SetActive(false);
        final_score = feather_count + water_count+((60-s_r.s)/10)+((60-s_r.m)/10)+((60-s_r.h)/10);
        final_score_text.text = "FINAL SCORE: " + final_score;

    }
    public void Lose()
    {
        endgameobject.SetActive(true);
        win.SetActive(false);
    }
}
