using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{
    public float health;
    BoidController bc;
    Vector3 deathpos;
    public GameObject Cadavre; 

    private void Start()
    {
         
      
    }
    void Update()
    {
        deathpos = transform.position;

        if (health <= 0)
        {
            Instantiate(Cadavre, deathpos, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    /// 'Hits' the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
    }
}