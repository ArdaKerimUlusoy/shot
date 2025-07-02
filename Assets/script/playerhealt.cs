using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100; 
    public int maxHealth = 150;     
    public bool shieldActive = false; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateShield(); 
        }
    }

    void ActivateShield()
    {
        
        if (!shieldActive)
        {
            currentHealth = maxHealth; 
            shieldActive = true; 
            Debug.Log($"Kalkan Aktif");
        }
    }

    
    public void TakeDamage(int damage, string damageSource)
    {
        if (shieldActive)
        {
            
        }
        else
        {
            currentHealth -= damage;
            
        }

        
        if (currentHealth <= 0)
        {
            Die();
        }
    }


    private void Die()
    {
        Debug.Log("Karakter Hakký Rahmetine Kavuþtu.");
        
    }
}
