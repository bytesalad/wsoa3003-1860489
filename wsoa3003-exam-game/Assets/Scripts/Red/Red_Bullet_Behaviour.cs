using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Bullet_Behaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform target;

    public void SetTarget(Transform _target)
    {
        target = _target;
        Vector2 velocity = (target.position - gameObject.transform.position).normalized * speed;
        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
