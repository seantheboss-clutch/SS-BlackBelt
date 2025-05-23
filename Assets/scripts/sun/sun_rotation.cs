using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sun_rotation : MonoBehaviour
{
    public Quaternion sq;
    public GameManager game_manager;
    public GameObject player;
    public Skybox skybox;
    public Quaternion p_i_quat;
    public int pi;
    public Vector3 sv;
    public Light sun;
    public float sun_speed = 30;
    public int sun_count;
    public Text[] time;
    public int h;
    public int m;
    public int s;
    
    void Awake()
    {

        start_mid_up_rot(0);
        time[0].text = "10";
        time[1].text = "00";
        time[2].text = "00";
    }

    
    void Update()
    {
        start_mid_up_rot(sun_speed);
        if (game_manager.end_game == false)
        {
            runSun();
        }
        time[0].text = h.ToString();
        if(m < 10)
        {
            time[1].text = "0" + m.ToString();
        }
        else
        {
            time[1].text = m.ToString();
        }
        if (s < 10)
        {
            time[2].text = "0" + Mathf.Floor(s).ToString();
        }
        else 
        { 
            time[2].text = Mathf.Floor(s).ToString(); 
        }
    }
    void start_mid_up_rot(float x)
    {
        sq = Quaternion.Euler(x, 0, 0);
        sv = new Vector3(sq.x, 0, 0);
        sun.transform.Rotate(sv);
        Debug.Log(sun.transform.rotation.x);
        if ((sun.transform.rotation.eulerAngles.x <= 240 && sun.transform.rotation.eulerAngles.x >= 0))
        {
            player.GetComponent<Renderer>().material.color = Color.black;
           
            StartCoroutine(AvertedNightDanger());
        } else
        {
            player.GetComponent<Renderer>().material.color = Color.yellow;
            StartCoroutine(NightDanger());

        }
    }
    IEnumerator NightDanger()
    {
        int diff = 4;
        diff /= 10;
        game_manager.water_count -= diff;
        
        yield return new WaitForSeconds(3);
    }
    IEnumerator AvertedNightDanger()
    {      
       yield return new WaitForSeconds(3);
    }
    void runSun()
    {
        if (game_manager.end_game == false)
        {
            if (s < 0)
            {
                if (m < 0)
                {
                    if (h < 0)
                    {
                        game_manager.end_game = true;
                        game_manager.Lose();
                    }
                    else
                    {
                        h -= 1;
                        m = 59;
                        s = 59;
                        game_manager.water_count -= 1;
                    }
                }
                else
                {
                    m -= 1;
                    s = 59;
                }
            }
            else
            {
                s -= 1;
            }
        }
    }
}
