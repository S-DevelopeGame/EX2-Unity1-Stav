using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPower : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] private KeyboardMover keyboardMover;
    [SerializeField] private float numberSpeed;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(other.gameObject);
            StartCoroutine(enableSpeed());

        }

    }
    private IEnumerator enableSpeed()
    {
        Debug.Log("BEFORE: " + keyboardMover.getSpeed());

        keyboardMover.setSpeed(keyboardMover.getSpeed() + numberSpeed);
        Debug.Log("AFTER: " + keyboardMover.getSpeed());
        yield return new WaitForSeconds(5);
        keyboardMover.setSpeed(keyboardMover.getSpeed() - numberSpeed);
        Debug.Log("END: " + keyboardMover.getSpeed());



    }

}
