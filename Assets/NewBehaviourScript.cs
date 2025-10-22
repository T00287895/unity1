using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float frequency = 3f;  // Speed of oscillation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        KeysControl();

        float angle = Mathf.Sin(Time.time / 2 * frequency) * 100;
        transform.rotation = Quaternion.Euler(angle, angle, angle);
        transform.position += Vector3.up / 100 * (angle / 100);

        Debug.Log(transform.position);
    }


    void KeysControl()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

    }
}
