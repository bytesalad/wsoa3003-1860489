using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Movement_Force_Based : MonoBehaviour
{
    [SerializeField] private float movement_speed;
    [SerializeField] private KeyCode movement_start_key;
    private Vector2 mouse_pos;
    private bool initial_key_press = false;

    public bool GetInitialKeyPress()
    {
        return initial_key_press;
    }

    private void Update()
    {
        if (Input.GetKeyDown(movement_start_key))
        {
            initial_key_press = true;
        }

        if (initial_key_press)
        {
            mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = Vector2.Lerp(transform.position, mouse_pos, movement_speed * Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((mouse_pos.x - transform.position.x) * movement_speed, (mouse_pos.y - transform.position.y) * 
                movement_speed);
        }
    }
}
