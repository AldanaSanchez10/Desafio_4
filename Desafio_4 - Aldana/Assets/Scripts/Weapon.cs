using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletRate;
    [SerializeField] private float bulletRateTime = 0.0f;

    [SerializeField] private float destroyBullet;

    void Update()
    {
        shootBullets();
    }

    private void shootBullets()
    {
        if (Time.time > bulletRateTime)
        {
            GameObject newBullet;

            newBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            bulletRateTime = Time.time + bulletRate;

            Destroy(newBullet, destroyBullet);
        }

    }

}
