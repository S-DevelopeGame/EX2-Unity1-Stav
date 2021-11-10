using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEnemy : MonoBehaviour
{
    [SerializeField] string triggeringTag;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            
            Destroy(other.gameObject);
    
            
                Destroy(this.gameObject);

            
        }






    }
}