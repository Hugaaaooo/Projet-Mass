using Unity.VisualScripting;
using UnityEngine;

public class Round : MonoBehaviour
{
    public float damage;
    public float yeeter = 3;

    private void Update()
    {
        yeeter -= Time.deltaTime;
        if (yeeter < 0) Destroy(gameObject);
    }

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