using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{ 
    [SerializeField] private Vector2[] locations;
    [SerializeField] private float movement_speed;
    [SerializeField] private float camera_depth = -100; //default camera depth because of editor
    [SerializeField] private bool move = false;
    [SerializeField] private float small_diff_value = 0.0000001f;
    private Vector2 current_move_location;

    private void Start()
    {
        current_move_location = locations[0];
    }

    public void InitiateMove(int index_location)
    {
        if (index_location < locations.Length)
        {
            current_move_location = locations[index_location];
        }
        move = true;
    }

    private void Update()
    {
        if (move)
        {
            Vector3 current_move_location_V3 = new Vector3(current_move_location.x, current_move_location.y, camera_depth);
            gameObject.transform.position = Vector3.Lerp(transform.position, current_move_location_V3, movement_speed * Time.deltaTime);

            //bool x = Mathf.Approximately(gameObject.transform.position.x, current_move_location_V3.x);
            //bool y = Mathf.Approximately(gameObject.transform.position.y, current_move_location_V3.y);
            //bool z = Mathf.Approximately(gameObject.transform.position.z, current_move_location_V3.z);

            bool x = false, y = false, z = false;

            if (Mathf.Abs(current_move_location_V3.x - gameObject.transform.position.x) <= small_diff_value)
            {
                x = true;
            }

            if (Mathf.Abs(current_move_location_V3.y - gameObject.transform.position.y) <= small_diff_value)
            {
                y = true;
            }

            if (Mathf.Abs(current_move_location_V3.z - gameObject.transform.position.z) <= small_diff_value)
            {
                z = true;
            }

            if (x && y && z)
            {
                move = false;
            }
        }
    }
}
