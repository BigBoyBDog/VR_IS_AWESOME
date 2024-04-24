using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject bullet;
    public Transform muzzle;
    private Rigidbody rb;
    public float speed = 20f;
   

    public void Update()
    {
        if (Input.GetButtonDown("XRI_Right_IndexTouch"))
        {
            Fire();
        }
    }

    public void Fire()
    {
        bullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        rb = bullet.GetComponent<Rigidbody>();
        if (rb != null )
        {
            rb.velocity = muzzle.forward * speed;
        }
    }

}
