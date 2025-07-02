using UnityEngine;
using TMPro;

public class Damage : MonoBehaviour
{
    public TextMeshProUGUI damageText; 
    public float displayTime = 0.5f; 
    private float timer = 0f;

    void Update()
    {
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                damageText.gameObject.SetActive(false); 
            }
        }
    }

    
    public void ShowDamage(int damageAmount, Vector3 position)
    {
        damageText.gameObject.SetActive(true); 
        damageText.text = $"-{damageAmount}"; 

        
        damageText.transform.position = Camera.main.WorldToScreenPoint(position);

        
        timer = displayTime;
    }
}

