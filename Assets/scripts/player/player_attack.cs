using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_attack : MonoBehaviour
{
    public eagle_move e_m;
    public GameManager game_manager;
    public KeyCode[] attack_letters = new KeyCode[3];
    public Text player_assigned_letter;
    public Text p_attack_limit_time_text;
    public KeyCode attack_letter = KeyCode.B;
    public int p_attack_count = 0;
    public int p_required_attack_streak = 3;
    public int index_picked = 0;
    public int times_eagle_attacked = 0;
    public float p_attack_limit_time = 5;
    public float palt;

    void Start()
    {
        palt = p_attack_limit_time;
        player_assigned_letter.text = attack_letter.ToString();
        attack_letters[0] = KeyCode.B;
        attack_letters[1] = KeyCode.Q;
        attack_letters[2] = KeyCode.P;
        print(attack_letters[0]);
        print(attack_letters[1]);
        print(attack_letters[2]);
    }
    void Update()
    {
        if (e_m.eagle_not_alerted == false)
        {
            Attack_Timer(p_required_attack_streak * (times_eagle_attacked+1));
        }
        player_assigned_letter.text = attack_letter.ToString();
        print(attack_letter);
    }
    void Roll()
    {
        index_picked = Random.Range(0, 3);
        attack_letter = attack_letters[index_picked];
        player_assigned_letter.text = attack_letter.ToString();
    }
    void Attack_Timer(int streak)
    {
        if (p_attack_count < streak)
        {
            //Roll();
            p_attack_limit_time -= Time.deltaTime;
            p_attack_limit_time_text.text = $"TIME LEFT TO ATTACK: {p_attack_limit_time}";
            if (p_attack_limit_time <= 0)
            {
                if (!Input.GetKey(attack_letter))
                {
                    game_manager.GetComponent<GameManager>().water_casualty = 1;
                    Roll();
                    print("Uh");
                    /*                      game_manager.GetComponent<GameManager>().water_casualty = 0;
                    */
                    p_attack_limit_time = palt;
                }
            }
            else
            {
                if (Input.GetKey(attack_letter))
                {
                    print("ayahyahyahyahyah");
                    p_attack_count += 1;
                    print(p_attack_count);
                    if(p_attack_count >= 20)
                    {
                        print("running");
                        e_m.eagle_not_alerted = true;
                        e_m.eagle_not_engaged = true;
                        game_manager.feather_count += 2;
                    }
                    Roll();
                    p_attack_limit_time = palt;

                } else
                {
                    game_manager.GetComponent<GameManager>().water_casualty = 1;
                }
            }
        }
        else
        {
            e_m.eagle_not_alerted = true;
            e_m.eagle_not_engaged = true;
            game_manager.water_count += 1;
        }
    }

}
