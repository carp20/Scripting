using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{ 

    public float speedFactor = 2.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
  
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;      
    }
}
