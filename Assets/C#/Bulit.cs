using UnityEngine;

public class bulit : MonoBehaviour
{
    public Transform gun;
    public GameObject bulletPrefab;
    public int speed = 10;
    public int bulletDamage = 20; // Adjust the damage as needed
    public float bulletLifetime = 5.0f; // Time in seconds before the bullet is destroyed

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, gun.position, gun.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;

            // Destroy the instantiated bullet after a delay (bulletLifetime)
            Destroy(bullet, bulletLifetime);
        }
    }

    
}
