using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad_Activator_Trigger : MonoBehaviour
{
    [SerializeField] private GameObject[] connected_pads;
    [SerializeField] private Material tintMat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar")
        {
            for (int i = 0; i < connected_pads.Length; i++)
            {
                connected_pads[i].GetComponent<BoxCollider2D>().enabled = false;
                //tint the pad:
                connected_pads[i].GetComponent<SpriteRenderer>().material = tintMat;
            }
            gameObject.GetComponent<SpriteRenderer>().material = tintMat;
        }
    }
}
