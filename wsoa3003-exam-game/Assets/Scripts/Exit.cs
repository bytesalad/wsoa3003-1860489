using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private KeyCode exit_button;

    private void Update()
    {
        if (Input.GetKeyDown(exit_button))
        {
            Application.Quit();
        }
    }
}
