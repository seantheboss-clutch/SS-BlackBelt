using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("feathers")]
    public int feather_count;
    public Text feather_count_text;

    [Header("store")]
    public bool got;
    public bool buy;
    public int debit_to_check;
    public int transaction;
    public GameObject store;

    [Header("water")]
    public int water_count;
    public Text water_count_text;
    public bool water_obtained;
    public int water_casualty;

    public GameObject player;
    public bool player_touched_well;
    public bool end_game;
    // Update is called once per fr
    // ame
    void Awake()
    {
        feather_count = 5;
        feather_count_text.text = "0";
        print(feather_count);
    }
    void Update()
    {
        if (!end_game)
        {
            if (got)
            {
                feather_count++;
                got = false;
            }
            if (buy)
            {
                Debit(transaction);
                buy = false;
            }
            if (water_obtained)
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
            }
            water_count_text.text = "water_count: "+water_count.ToString();
            feather_count_text.text ="feather_count: "+feather_count.ToString();

        }
        else
        {
            //"Load win or lose scene
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
}
