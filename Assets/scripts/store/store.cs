using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public GameObject game_manager;
    public GameObject player;
    public GameObject[] store_items;
    public bool can_buy_item;
    public int feather_count_st;
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
            feather_count_st = game_manager.GetComponent<GameManager>().feather_count;
            if(feather_count_st >= prices[price_req-1])
            {
                can_buy_item = true;
            }
        }
        if(can_buy_item)
        {
            buyItem();
            can_buy_item = false;
            //player.GetComponent<player_powerup>().powerup = names_of_items[price_req - 1];
        }    
    }
    void buyItem()
    {
        Instantiate(store_items[price_req - 1], new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
        game_manager.GetComponent<GameManager>().transaction = prices[price_req - 1];
        game_manager.GetComponent<GameManager>().buy = true;
        /*can_buy_item = false;*/
        request_pur = false;
    }
}
