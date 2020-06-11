using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_Zone_Trigger : MonoBehaviour
{
    [SerializeField] private Camera_Move camera_move_script;
    [SerializeField] private int location_index;
    [SerializeField] private bool isActive = true;

    public void SetActive(bool value)
    {
        isActive = value;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Avatar") && isActive)
        {
            camera_move_script.InitiateMove(location_index);
            isActive = false;
            gameObject.GetComponent<Transition_Zone_Activator>().ActivateZone();
        }
    }
}
