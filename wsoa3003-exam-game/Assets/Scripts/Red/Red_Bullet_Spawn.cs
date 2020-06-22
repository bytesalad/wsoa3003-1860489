using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Bullet_Spawn : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private AnimationCurve behaviour_curve;
    [SerializeField] private GameObject red_bullet;
    [SerializeField] private float max_period;
    [SerializeField] private float wavelength;
    private float period_time = 0;
    private float time = 0;

    private void Update()
    {
        if (time >= wavelength)
        {
            time = 0;
            GameObject instantiated_red = Instantiate(red_bullet, gameObject.transform.position, Quaternion.identity, gameObject.transform);
            instantiated_red.GetComponent<Red_Bullet_Behaviour>().SetTarget(target);
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
