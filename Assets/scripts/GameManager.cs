using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("in the beginning...")]
    /*public int rerun;*/ 
    public Text high_score_m_text;
    public bool high_score_achieved;

    [Header("feathers")]
    public float feather_count;


    [Header("store")]
    public bool got;
    public bool buy;
    public int debit_to_check;
    public int transaction;
    public GameObject store;

    [Header("water")]
    public float water_count;
    public bool water_obtained;
    public float water_casualty;
    

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
    public float final_score;
    public Text final_score_text;
    public float high_score = 0;
    public Text high_score_text;
    public Text ui;
    public Slider restart;
    public Text win_or_lose;

    [Header("Sliders")]
    public Slider water_slider;
    public Text water_count_text;
    public Slider feather_slider;
    public Text feather_count_text;


    [Header("journals")]

    public string[] journal_secrets = {"I","'","M","I","N","N","E","S","T"};
    public Text[] secret_text = {};
    public bool revelation;
    public int revelations;
    public GameObject step1;
    public GameObject step2;
    public GameObject friend;
    // Update is called once per fr
    // ame

    void Awake()
    {
        /*if(PlayerPrefs.GetInt("high_score_achived") != 1)
        {
            high_score = 0;
        } else
        {
            high_score = PlayerPrefs.GetFloat("High Score");
        }*/
        high_score = PlayerPrefs.GetFloat("High Score");
        //high_score_m_text.text = $"HIGH SCORE: {high_score.ToString()}";
        
    }
    void Start()
    {
        endgameobject.SetActive(false);
        destination = false;
        water_count = 5;
        feather_count = 0; //CHANGED INITIAL FEATHER count to speed up.
        feather_slider.value = feather_count;
        water_slider.value = water_count;
        print(feather_count);
        for(int i = 0; i < secret_text.Length; i++)
        {
            secret_text[i].text = "_"; //SetValue("_", i);
        }
        final_score_text.text = "FINAL SCORE: ";
        high_score_text.text = $"High Score: {high_score}";
        friend.SetActive(true);
        revelations = 9;
        step1.SetActive(false);
        step2.SetActive(false);
        win_or_lose.text = "";
    }
    void Update()
    {
        feather_count_text.text = $"Feathers Collected: {feather_slider.value.ToString()}";
        water_count_text.text = $"Water Left: {water_slider.value.ToString()}";
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
                revelations += 1;
                revelation = false;    
                
            }
            if(revelations == 10)
            {
                friend.SetActive(true);
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
    void Casualty(float casualty)
    {
        water_count -= casualty;
        water_casualty = 0;
    }
    void Reveal()
    {
        int secret_to_reveal_index = Random.Range(0, secret_text.Length - 1);
        secret_text[secret_to_reveal_index].text = journal_secrets[secret_to_reveal_index];
        revelations -= 1;
        if(revelations == 0)
        {
            step1.SetActive(true);
            step1.GetComponent<BoxCollider>();
            step2.SetActive(true);
            step2.GetComponent<BoxCollider>();
        }
    }
    public void Win()
    {
        endgameobject.SetActive(true);
        lose.SetActive(false);
        win_or_lose.text = "YOU WIN";
        FinalScore();

    }
    public void Lose()
    {
        endgameobject.SetActive(true);
        win.SetActive(false);
        win_or_lose.text = "YOU LOSE";

    }
    public void Restart()
    {
        SceneManager.LoadScene(7);
    }
    public void FinalScore()
    {
        final_score = feather_count + water_count + ((60 - s_r.s) / 10) + ((60 - s_r.m) / 10) + ((60 - s_r.h) / 10);
        final_score_text.text = $"FINAL SCORE (LOWEST VALUE IN INTERVAL): {final_score}";
        high_score = Mathf.Max(high_score,final_score);
        high_score_text.text = $"HIGH SCORE: {high_score}";
        PlayerPrefs.SetFloat("High Score", high_score);
        PlayerPrefs.SetInt("high_score_achieved",1);

/*        high_score_achieved = true;*/
    }
}
