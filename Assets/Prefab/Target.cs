using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{
    public float health;
    BoidController bc;
    Transform deathpos;
    public GameObject Cadavre; 

    private void Start()
    {
         
      
    }
    void Update()
    {
        deathpos = transform;

        if (health <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(Cadavre, deathpos);
            
        }
    }

    /// 'Hits' the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
    }
}