using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_Zone_Activator : MonoBehaviour
{
    [SerializeField] private Transition_Zone_Trigger triggerScript;

    public void ActivateZone()
    {
        triggerScript.SetActive(true);
    }
}
