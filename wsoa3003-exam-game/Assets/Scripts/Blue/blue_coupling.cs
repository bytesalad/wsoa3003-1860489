using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_coupling : MonoBehaviour
{
    [SerializeField] private float follow_speed_avatar;
    [SerializeField] private float follow_speed_goal;
    private GameObject avatar;
    private GameObject goal;
    private bool follow_avatar = false;
    private bool follow_goal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar" && !follow_goal)
        {
            avatar = collision.gameObject;
            follow_avatar = true;
        }
        if (collision.gameObject.tag == "Goal")
        {
            goal = collision.gameObject;
            follow_avatar = false;
            follow_goal = true;
        }
    }

    private void Update()
    {
        if (follow_avatar)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((avatar.transform.position.x - transform.position.x) * follow_speed_avatar,
                (avatar.gameObject.transform.position.y - transform.position.y) * follow_speed_avatar);
        }
        else if (follow_goal)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((avatar.transform.position.x - transform.position.x) * follow_speed_avatar,
                (avatar.gameObject.transform.position.y - transform.position.y) * follow_speed_goal);
        }
    }
}
