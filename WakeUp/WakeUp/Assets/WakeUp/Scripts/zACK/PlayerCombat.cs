using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    /**private float timeBtwAttack;
    private float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatisEnemies;
    public float attackRange;
    public int damage;**/

    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;

    //DMG POINT

    public int swordDmg = 40;

    //attack
    public float attackRate = 4f;
    float nextAttackTime = 0f;


    void Update()
    {
        /** Input.GetKeyDown(KeyCode.K);

         Attack();**/
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Attack();
                nextAttackTime = Time.time * 3f / attackRate;

            }
            if (Input.GetKeyDown(KeyCode.J)){
                Cast();
            }
        }





    }


    void Attack() {
        //attack animation
        animator.SetTrigger("Attack");

        //enemy detect

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatisEnemies);

        //dmg

        /** for(int i = 0; i < enemiesToDamage; i++)
         {
         enemiesToDamage[i].GetComponent<Enemy>().health -= damage;
         }**/

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("Enemy Hit" + enemy.name);

            enemy.GetComponent<EnemyCombat>().TakeDmg(swordDmg);
        }

    }
    void Cast()
    {

        animator.SetTrigger("Spell");
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
