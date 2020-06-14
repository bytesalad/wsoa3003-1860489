using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_coupling : MonoBehaviour
{
    [SerializeField] private float follow_speed_avatar;
    [SerializeField] private float follow_speed_goal;
    [SerializeField] private boundary_gap_open boundary_Gap_Open;
    private GameObject follow;
    private bool couple_avatar = false;
    private bool couple_goal = false;
    private bool initiate_open = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar" && !couple_goal)
        {
            follow = collision.gameObject;
            couple_avatar = true;
        }
        if (collision.gameObject.tag == "Goal")
        {
            follow = collision.gameObject;
            couple_avatar = false;
            couple_goal = true;
        }
    }

    private void Update()
    {
        if (couple_avatar)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((follow.transform.position.x - transform.position.x) * follow_speed_avatar,
                (follow.gameObject.transform.position.y - transform.position.y) * follow_speed_avatar);
        }
        else if (couple_goal)
        {
            if (!initiate_open)
            {
                boundary_Gap_Open.Open();
                initiate_open = true;
            }
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((follow.transform.position.x - transform.position.x) * follow_speed_avatar,
                (follow.gameObject.transform.position.y - transform.position.y) * follow_speed_goal);
        }
    }
}
