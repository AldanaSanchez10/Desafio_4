using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    void Update()
    {
        transform.position += transform.forward * (bulletSpeed * Time.deltaTime);

        upgradeScale();

    }
    private void upgradeScale()
    {
        if (Input.GetKeyDown("space"))
        {

            transform.localScale += Vector3.one * (Time.deltaTime * 2);

        }
    }

}
