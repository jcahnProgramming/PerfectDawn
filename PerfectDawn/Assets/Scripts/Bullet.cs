using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Vector3 bulletVelocity;
    public GameObject BarrelTip;
    public GameObject projectile;


    public void Projectile()
    {
        bulletVelocity = BarrelTip.transform.position;
        Instantiate(projectile, bulletVelocity, Quaternion.identity);
    }
}
