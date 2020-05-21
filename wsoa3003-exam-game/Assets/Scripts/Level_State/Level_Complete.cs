using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour
{
    [SerializeField] private KeyCode proceed_key;
    [SerializeField] private string scene_load;

    private void Update()
    {
        if (Input.GetKeyDown(proceed_key))
        {
            SceneManager.LoadScene(scene_load);
        }
    }
}
