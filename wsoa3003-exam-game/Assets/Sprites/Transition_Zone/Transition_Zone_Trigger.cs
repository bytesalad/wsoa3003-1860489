using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_Zone_Trigger : MonoBehaviour
{
    [SerializeField] private Camera_Move camera_move_script;
    [SerializeField] private int location_index;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar")
        {
            camera_move_script.InitiateMove(location_index);
        }
    }
}
