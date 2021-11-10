using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {

    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
        healthBar.SetMaxHealth(maxHealth);
    }


    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled && this.tag == "Player") {
            TakeDamage(1);
            Destroy(other.gameObject);
            if (currentHealth == 0)
            {
                Destroy(this.gameObject);

            }
        }
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    
}
