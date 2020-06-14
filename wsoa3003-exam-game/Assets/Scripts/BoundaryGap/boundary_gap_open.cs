using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary_gap_open : MonoBehaviour
{
    [SerializeField] private string open_parameter;
    [SerializeField] private string idle_parameter;

    [SerializeField] private float animation_duration;
    private float time = 0f;
    [SerializeField] private bool isOpen = false;

    public void Open()
    {
        gameObject.GetComponent<Animator>().SetBool(open_parameter, true);
        isOpen = true;
        time = 0;
    }

    private void Update()
    {
        if (isOpen)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if (time < animation_duration)
            {
                time += Time.deltaTime;
            }
            else if (time >= animation_duration)
            {
                gameObject.GetComponent<Animator>().SetBool(idle_parameter, true);
            }
        }
    }
}
