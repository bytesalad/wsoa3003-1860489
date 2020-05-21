using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Trigger : MonoBehaviour
{
    [SerializeField] private string next_scene_name;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            SceneManager.LoadScene(next_scene_name);
        }
    }
}
