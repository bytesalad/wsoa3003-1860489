using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Collision : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float continuous_damage_delay;
    private float time = 0;

    public float GetContinuousDamageDelay()
    {
        return continuous_damage_delay;
    }

    private void Start()
    {
        time = continuous_damage_delay;
    }

    private void Update()
    {
        if (time < continuous_damage_delay)
        {
            time += Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Red") && (time >= continuous_damage_delay))
        {
            gameObject.GetComponent<Avatar_Health>().ChangeHealth(damage);
            time = 0;
            gameObject.GetComponent<Avatar_Immunity_Animation>().Collided();
        }
    }
}
