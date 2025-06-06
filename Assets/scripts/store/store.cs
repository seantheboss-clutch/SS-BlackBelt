using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public GameObject game_manager;
    public GameObject player;
    public GameObject[] store_items;
    public bool can_buy_item;
    public bool cbi;
    public float feather_count_st;
    public string[] names_of_items = {
        "water",
        "hook"
    };
    public int[] prices = { 1, 3 };
   
    public int price_req;
    public bool request_pur;

    void Start()
    {
        can_buy_item = false;
        cbi = true;
        store_items[0].SetActive(true);
        //store_items[1].SetActive(true);
    }
    void Update()
    {
        if(request_pur)
        {
            feather_count_st = game_manager.GetComponent<GameManager>().feather_count;
            if(feather_count_st >= prices[price_req-1])
            {
                can_buy_item = true;
                cbi = true;
            }
        }
        if(can_buy_item)
        {
            if (cbi)
            {
                buyItem();
                //can_buy_item = false; to see if the powerup "husk" will stop hyperinstantiating
                player.GetComponent<player_powerup>().powerup = names_of_items[price_req - 1];
                can_buy_item = false;
                request_pur = false;
            }
        }    
    }
    void buyItem()
    {
        Instantiate(store_items[price_req - 1], new Vector3(player.transform.position.x, player.transform.position.y+30, player.transform.position.z), Quaternion.identity);
        game_manager.GetComponent<GameManager>().transaction = prices[price_req - 1];
        game_manager.GetComponent<GameManager>().buy = true;
        cbi = false;
        //player.GetComponent<player_powerup>().powerup = $"{names_of_items[price_req - 1]}";
    }
}
