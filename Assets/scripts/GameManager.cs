using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int feather_count;
    public bool got;
    public bool buy;
    public bool end_game;
    public int transaction;
    public Text feather_count_text;
    public int water_count;
    public Text water_count_text;
    public GameObject player;
    public bool water_obtained;
    public bool player_touched_well;
    public int debit_to_check;
    public GameObject store;
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
 
        feather_count_text.text = feather_count.ToString();
        if (water_obtained)
        {
            water_count += 10;
        } else if (player_touched_well)
        {
            water_count += 5;
        }
    }
    void Debit(int transact)
    {
        feather_count -= transact;
    }
}
