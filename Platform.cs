using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 directions;
    public bool isActive;

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            transform.position += directions * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlatformStop")
        {
            directions *= -1;
        }

        if(other.tag == "Player")
        {
            isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;
        }
    }
}
