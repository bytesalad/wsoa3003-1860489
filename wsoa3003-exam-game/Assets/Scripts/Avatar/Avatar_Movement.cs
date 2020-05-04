using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Movement : MonoBehaviour
{
    [SerializeField] private float movement_speed;
    [SerializeField] private KeyCode movement_start_key;
    private Vector2 mouse_pos;
    private bool initial_key_press = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            initial_key_press = true;
        }

        if (initial_key_press)
        {
            mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.Lerp(transform.position, mouse_pos, movement_speed * Time.deltaTime);
        }
    }
}
