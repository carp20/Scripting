using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioSource audioSource;
    public AudioClip collectSound;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
    }

    public void CollectCoins()
    {

        coins++;
        audioSource.PlayOneShot(collectSound);
        print("Собранные монетки:" + coins);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

}
