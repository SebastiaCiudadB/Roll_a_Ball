using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private bool up = true;
    private float speed = 0.5f;

    private float StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            if (transform.position.y < (StartPosition + 0.25)){ transform.position = transform.position + (new Vector3(0, speed, 0) * Time.deltaTime); }
            else { up = false; }
        }
        else
        {
            if (transform.position.y > (StartPosition - 0.25)) { transform.position = transform.position - (new Vector3(0, speed, 0) * Time.deltaTime); }
            else { up = true; }
        }
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
