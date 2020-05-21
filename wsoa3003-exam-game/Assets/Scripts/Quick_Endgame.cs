using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quick_Endgame : MonoBehaviour
{
    [SerializeField] private string scene_load;

    public void End()
    {
        SceneManager.LoadScene(scene_load);
    }
}
