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
    // Update is called once per frame
    void Awake()
    {
        feather_count_text.text = "0"; 
    }
    void Update()
    {
        if (got)
        {
            feather_count++;
        }
        if (buy)
        {
            Debit(transaction);
        }
        feather_count_text.text = feather_count.ToString();
    }
    void Debit(int transact)
    {
        feather_count -= transact;
    }
}
