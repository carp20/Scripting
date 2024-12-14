using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    //public string name = "name";
    //public int damage = 5;

    void Start()
    {
        health += level;
        print(health);
        // fff
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
        //run

    }
}
