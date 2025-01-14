using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    // Start is called before the first frame update
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<GoblinHealth>() != null)
        {
            GoblinHealth health = collider.GetComponent<GoblinHealth>();
            health.Damage(damage);
        }
        if(collider.GetComponent<EnemyTankHealth>() != null)
        {
            EnemyTankHealth health = collider.GetComponent<EnemyTankHealth>();
            health.Damage(damage);
        }
    }
}
