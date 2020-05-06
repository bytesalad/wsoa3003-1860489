using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Immunity_Animation : MonoBehaviour
{
    [SerializeField] private Color flash_colour;
    [SerializeField] private float flash_rate;
    private Color normal_colour;
    private float damage_delay_time;
    private float flash_time;

    public void Collided()
    {
        damage_delay_time = 0;
    }

    private void Start()
    {
        damage_delay_time = gameObject.GetComponent<Avatar_Collision>().GetContinuousDamageDelay();
        flash_time = flash_rate;
        normal_colour = gameObject.GetComponent<SpriteRenderer>().color;
    }

    private void Update()
    {
        if (damage_delay_time < gameObject.GetComponent<Avatar_Collision>().GetContinuousDamageDelay())
        {
            damage_delay_time += Time.deltaTime;
            if (flash_time < flash_rate)
            {
                flash_time += Time.deltaTime;
            }
            else
            {
                flash_time = 0;
                if (gameObject.GetComponent<SpriteRenderer>().color == normal_colour)
                {
                    gameObject.GetComponent<SpriteRenderer>().color = flash_colour;
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().color = normal_colour;
                }
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = normal_colour;
        }
    }
}
