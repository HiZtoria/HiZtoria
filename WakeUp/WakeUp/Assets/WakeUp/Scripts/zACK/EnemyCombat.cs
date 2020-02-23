using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{

    public Animator anim;

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDmg(int damage)
    {
        currentHealth -= damage;


        //Shake



        anim.SetTrigger("Hurt");

        if (currentHealth <= 0) {
            Die();
        }
    }

    void Die() {

        Debug.Log("Enemy DIED");
        //enemy dead anim
        anim.SetBool("isDead", true);
        // off anemy

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }
}
