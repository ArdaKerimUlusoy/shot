using UnityEngine;
using TMPro;

public class silahdegistirme : MonoBehaviour
{
    public Gun[] guns;
    public TextMeshProUGUI weaponNameText;
    private int currentGunIndex = 0;

    void Start()
    {
        UpdateActiveGun();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentGunIndex = (currentGunIndex - 1 + guns.Length) % guns.Length;
            UpdateActiveGun();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentGunIndex = (currentGunIndex + 1) % guns.Length;
            UpdateActiveGun();
        }


        if (Input.GetButton("Fire1"))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 fireDirection = mousePosition - (Vector2)guns[currentGunIndex].firePoint.position;
            guns[currentGunIndex].Shoot(fireDirection);
        }
    }


    void UpdateActiveGun()
    {
        for (int i = 0; i < guns.Length; i++)
        {
            guns[i].gameObject.SetActive(i == currentGunIndex);
        }

    }
}