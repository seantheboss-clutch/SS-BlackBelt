using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_attack : MonoBehaviour
{
    public eagle_move e_m;
    public GameObject game_manager;
    public string[] attack_letters = { "b", "q", "p" };
    public Text player_assigned_letter;
    public Text p_attack_limit_time_text;
    public string attack_letter = "b";
    public int p_attack_count = 0;
    public int p_required_attack_streak = 10;
    public int times_eagle_attacked = 0;
    public float p_attack_limit_time = 5;

    void Start()
    {
        player_assigned_letter.text = attack_letter;
    }
    void Update()
    {
        if(e_m.eagle_not_alerted == false)
        {
            Attack_Timer(p_required_attack_streak * times_eagle_attacked);
        }
    }
        void Roll()
        {
            attack_letter = attack_letters[Random.Range(0, 2)];
            player_assigned_letter.text = attack_letter.ToString();          
        }
        void Attack_Timer(int streak)
        {
            if(p_attack_count < streak)
            {
                //Roll();
                p_attack_limit_time -= Time.deltaTime;
                p_attack_limit_time_text.text = p_attack_limit_time.ToString();
                if(p_attack_limit_time <= 0)
                {
                    if(!Input.GetKey(attack_letter))
                    {
                        game_manager.GetComponent<GameManager>().water_casualty = 1;
                        Roll();
/*                      game_manager.GetComponent<GameManager>().water_casualty = 0;
*/                      p_attack_limit_time = 0;
                    }
                } else
                {
                    if (Input.GetKey(attack_letter))
                    {
                        p_attack_count += 1;
                        Roll();
                        p_attack_limit_time = 0;
                        
                    }
                }
            } else
            {
                e_m.eagle_not_alerted = true;
                e_m.eagle_not_engaged = true;
            }
        }

}
