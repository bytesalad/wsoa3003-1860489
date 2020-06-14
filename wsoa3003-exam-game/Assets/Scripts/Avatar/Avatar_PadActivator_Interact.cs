using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_PadActivator_Interact : MonoBehaviour
{
    [SerializeField] private Color purple_colour;
    [SerializeField] private ParticleSystem particle_system;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Purple_Pad_Activator")
        {
            Debug.Log("Yee");
            gameObject.GetComponent<SpriteRenderer>().color = purple_colour;
            var main = particle_system.main;
            main.startColor = purple_colour;
            particle_system.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Purple_Pad_Activator")
        {
            Debug.Log("Yee");
            gameObject.GetComponent<SpriteRenderer>().color = purple_colour;
            var main = particle_system.main;
            main.startColor = purple_colour;
            particle_system.Play();
        }
    }
}
