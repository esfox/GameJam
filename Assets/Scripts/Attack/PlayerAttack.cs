using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   private float AttackDelay;
   public float StartAttackDelay;

   public Transform AttackerPos;
   public float damageRange;
   public LayerMask destructibles;
   public int damage;
    public Animator camAnim;

    private Movement playerMove;

    private void Start()
    {
        playerMove = FindObjectOfType<Movement>();
    }

    void Update()
    {
        if (AttackDelay <= 0)
        {
            //if (Input.GetMouseButton(0))
            if (Input.GetKey(KeyCode.Space))
            {
                camAnim.SetTrigger("Shake");
                playerMove.currentStatus = PlayerStatus.attack;
                Collider2D[] propsToDamage = Physics2D.OverlapCircleAll(AttackerPos.position, damageRange, destructibles);
                for (int i = 0; i < propsToDamage.Length; i++)
                {                    
                    propsToDamage[i].GetComponent<DestructibleProps>().TakeDamage(damage);
                }

                Debug.Log("ATTACK");
                AttackDelay = StartAttackDelay;
                playerMove.currentStatus = PlayerStatus.idle;
            }
            
        }

        else
        {
            AttackDelay -= Time.deltaTime;
            //Debug.Log(AttackDelay);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackerPos.position, damageRange);
    }
}
