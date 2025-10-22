using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    public float frequency = 3f;  // Speed of oscillation

    private string log = "";

    public Transform center; // The center point of the circle
    public float radius = 5f; // Radius of the circle
    public float speed = 2f; // Speed of rotation

    private float angle = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        //float angle = Mathf.Sin(Time.time / 2 * frequency) * 100;
        //transform.position += Vector3.up / 100 * (angle / 200);


        angle += speed * Time.deltaTime; // Increment the angle over time
        float x = 0 + Mathf.Cos(angle) * radius;
        float z = 0 + Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, transform.position.y / 5, z); // Update position

    }
}
