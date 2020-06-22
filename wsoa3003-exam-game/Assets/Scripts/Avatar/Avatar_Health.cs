using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Avatar_Health : MonoBehaviour
{
    [SerializeField] private int max_health;
    [SerializeField] private int current_health;
    [SerializeField] private Text health_text;
    [SerializeField] private string end_game_scene;

    public int GetMaxHealth()
    {
        return max_health;
    }

    public int GetCurrentHealth()
    {
        return current_health;
    }

    public int ChangeHealth(int value)
    {
        int final = current_health + value;
        if (final > max_health)
        {
            //clamp current health
            current_health = max_health;
        }
        else if (final == 0)
        {
            //game over
            SceneManager.LoadScene(end_game_scene);
            current_health = 0;
        }
        else
        {
            current_health = final;
        }
        return current_health;
    }

    private void Update()
    {
        health_text.text = "Health: " + current_health.ToString();
    }
}
