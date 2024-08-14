using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public GameObject game_manager;
    public GameObject player;
    public GameObject[] store_items;
    public int[] prices =
    {
        5,
        10,
        15
    };
    public int price_req;
    public bool request_pur;
    void Update()
    {
        if(request_pur)
        {
            purchase(price_req);
        }
    }
    void purchase(int p)
    {
        if(game_manager.GetComponent<GameManager>().feather_count >= prices[p-1])
        {
            Instantiate(store_items[p-1],new Vector3(player.transform.position.x+7,player.transform.position.y,player.transform.position.z+5),Quaternion.identity);
            game_manager.GetComponent<GameManager>().transaction = prices[p - 1];
            game_manager.GetComponent<GameManager>().buy = true;
        }
    }
}
