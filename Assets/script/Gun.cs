using UnityEngine;

public class Gun : MonoBehaviour
{
    public string gunName;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    public int damage = 20;

    private float nextFireTime = 0f;

    public void Shoot(Vector2 aimDirection)
    {
        if (Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;


            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bulletScript = bullet.GetComponent<Bullet>();

            bulletScript.hasar = damage;


            if (bulletScript != null)
            {
                bulletScript.SetDirection(aimDirection);
                bulletScript.damage = damage;

            }
        }
    }
}