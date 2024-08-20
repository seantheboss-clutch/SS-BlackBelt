using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public GameObject game_manager;
    public GameObject player;
    public GameObject[] store_items;
    public bool can_buy_item;
    public string[] names_of_items = {
        "water",
        "hook",
        "light"
    };
    public int[] prices = { 1, 3, 5 };
   
    public int price_req;
    public bool request_pur;
    void Update()
    {
        if(request_pur)
        {
            game_manager.GetComponent<GameManager>().check_balance = true;
            game_manager.GetComponent<GameManager>().debit_to_check = price_req;
        }
        if(can_buy_item)
        {
            Instantiate(store_items[price_req - 1], new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
            game_manager.GetComponent<GameManager>().transaction = prices[price_req - 1];
            game_manager.GetComponent<GameManager>().buy = true;
            player.GetComponent<player_powerup>().powerup = names_of_items[price_req - 1];
        }    
    }
}
