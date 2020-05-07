using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quick_Endgame : MonoBehaviour
{
    [SerializeField] private string text;

    public void End()
    {
        gameObject.GetComponent<Text>().text = text;
    }
}
