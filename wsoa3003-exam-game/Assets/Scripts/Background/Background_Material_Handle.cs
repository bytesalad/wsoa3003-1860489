using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Material_Handle : MonoBehaviour
{
    [SerializeField] private float max_x_value;
    [SerializeField] private float x_value_inc_factor;
    private float x_value = 0;
    private bool change_direction = false;

    private void Update()
    {
        if (!change_direction)
        {
            x_value += Time.deltaTime * x_value_inc_factor;
            if (x_value >= max_x_value)
            {
                x_value = max_x_value;
                change_direction = true;
            }
        }
        else if (change_direction)
        {
            x_value -= Time.deltaTime * x_value_inc_factor;
            if (x_value <= 0)
            {
                x_value = 0;
                change_direction = false;
            }
        }
        float sine_value = Mathf.Sin(x_value);
        gameObject.GetComponent<SpriteRenderer>().material.SetFloat("_Fade", sine_value);
    }
}
