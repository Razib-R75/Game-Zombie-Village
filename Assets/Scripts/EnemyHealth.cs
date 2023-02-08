using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    RagdollManager ragdollManager;
    Animator animy;
    [HideInInspector] public bool isDead;

    private void Start()
    {
        ragdollManager = GetComponent<RagdollManager>();
        animy = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
            if (health <= 0) EnemyDeath();
            else Debug.Log("Hit");
        }
    }

    void EnemyDeath()
    {
        ragdollManager.TriggerRagdoll();
        Debug.Log("Death");
        animy.SetBool("kill", true);
        animy.SetBool("atk", false);
        animy.SetBool("runn", false);
        transform.position =  new Vector3(0, -28, 0);
    }
}
