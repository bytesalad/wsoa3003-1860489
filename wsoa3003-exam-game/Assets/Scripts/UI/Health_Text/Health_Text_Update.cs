using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Text_Update : MonoBehaviour
{
    [SerializeField] private Avatar_Health avatar_health;

    private void Update()
    {
        gameObject.GetComponent<Text>().text = "Health: " + avatar_health.GetCurrentHealth().ToString();
    }
}
