using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_PadActivator_Interact : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle_system;
    [SerializeField] private Material no_tint;
    [SerializeField] private Material purple_mat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Purple_Pad_Activator")
        {
            gameObject.GetComponent<SpriteRenderer>().material = purple_mat;
            particle_system.Play();
        }

        if (collision.gameObject.tag == "Colour_Reset")
        {
            gameObject.GetComponent<SpriteRenderer>().material = no_tint;
        }
    }
}
