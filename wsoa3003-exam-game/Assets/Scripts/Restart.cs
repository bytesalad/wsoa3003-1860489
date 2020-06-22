using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private string scene_to_load;
    [SerializeField] private KeyCode restart;

    private void Update()
    {
        if (Input.GetKeyDown(restart))
        {
            SceneManager.LoadScene(scene_to_load);
        }
    }
}
