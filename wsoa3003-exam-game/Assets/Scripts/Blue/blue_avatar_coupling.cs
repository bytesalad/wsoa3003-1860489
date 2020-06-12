using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_avatar_coupling : MonoBehaviour
{
    [SerializeField] private float follow_speed;
    private GameObject avatar;
    private bool follow = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar")
        {
            avatar = collision.gameObject;
            follow = true;
        }
    }

    private void Update()
    {
        if (follow)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((avatar.transform.position.x - transform.position.x) * follow_speed,
                (avatar.gameObject.transform.position.y - transform.position.y) * follow_speed);
        }
    }
}
