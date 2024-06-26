using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    [Header ("Attack")]
    [SerializeField] private Transform AttackController;
    [SerializeField] private float AttackRadius;

    [Header ("Comoponents")]
    private Animator Animator;
    private void Start() {
        Animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Animator.SetTrigger("Attack");
        }
    }

    // Update is called once per frame
    private void Attack()
    {
        Collider2D[] orbs = Physics2D.OverlapCircleAll(AttackController.position, AttackRadius);
        foreach (Collider2D collision in orbs)
        {
            if (collision.CompareTag("Orb"))
            {
                //collision.transform.GetComponent<Orb>().Takedamage();
                //onOrb?.Invoke();

                Destroy(collision.gameObject);
            }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackController.position, AttackRadius);
    }
}
