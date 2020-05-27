using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour {

    public float health = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float dmg)
    {
        health -= dmg;

        if (health <= 0) 
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
