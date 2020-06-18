using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar_Movement_Force_Based : MonoBehaviour
{
    [SerializeField] private float movement_speed;
    private Vector2 mouse_pos;
    private bool initial_key_press = false;
    [SerializeField] private Text click_start;

    public bool GetInitialKeyPress()
    {
        return initial_key_press;
    }

    private void Update()
    {
        if (initial_key_press)
        {
            mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = Vector2.Lerp(transform.position, mouse_pos, movement_speed * Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((mouse_pos.x - transform.position.x) * movement_speed, (mouse_pos.y - transform.position.y) * 
                movement_speed);
        }
    }

    private void OnMouseDown()
    {
        initial_key_press = true;
        click_start.gameObject.SetActive(false);
    }
}
