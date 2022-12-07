using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;
    BoidController bc;

    private void Start()
    {
        bc = FindObjectOfType<BoidController>();
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    /// 'Hits' the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
    }
}