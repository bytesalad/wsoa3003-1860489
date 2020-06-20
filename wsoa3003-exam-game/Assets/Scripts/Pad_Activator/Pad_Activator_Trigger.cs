using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad_Activator_Trigger : MonoBehaviour
{
    [SerializeField] private GameObject[] connected_pads;
    [SerializeField] private Material tintMat;
    [SerializeField] private Material no_tint_mat;
    [SerializeField] private Pad_Activator_Trigger[] to_deactivate;

    public void Deactivate()
    {
        for (int i = 0; i < connected_pads.Length; i++)
        {
            connected_pads[i].GetComponent<BoxCollider2D>().enabled = true;
            //tint the pad:
            connected_pads[i].GetComponent<SpriteRenderer>().material = no_tint_mat;
        }
        gameObject.GetComponent<SpriteRenderer>().material = no_tint_mat;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar")
        {
            for (int i = 0; i < to_deactivate.Length; i++)
            {
                to_deactivate[i].Deactivate();
            }
            
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
