using Unity.VisualScripting;
using UnityEngine;

public class Round : MonoBehaviour
{
    public float damage;

    void OnCollisionEnter(Collision other)
    {
        Target target = other.gameObject.GetComponentInParent<Target>();
        // Only attempts to inflict damage if the other game object has
        // the 'Target' component
        if (target != null)
        {
            target.Hit(damage);
            Destroy(gameObject); // Deletes the round
        }
    }
}