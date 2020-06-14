using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger_Trigger : MonoBehaviour
{
    [SerializeField] private string scene_load;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Avatar")
        {
            SceneManager.LoadSceneAsync(scene_load);
        }
    }
}
