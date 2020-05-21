using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin_Move_Behaviour : MonoBehaviour
{
    [SerializeField] private Avatar_Movement_Force_Based avatar_movement_script;

    private void Update()
    {
        if (avatar_movement_script.GetInitialKeyPress())
        {
            gameObject.GetComponent<Text>().text = "";
        }
    }
}
