using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private AudioSource audio;
    void OnCollisionEnter(Collision collision)
    {
        // Assuming zombies have a tag "Zombie" and a script zombieController for taking damage
        if (collision.gameObject.tag == "Zombie")
        {
            //audio.Play();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
