using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : Life
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            ChangeLife(-collision.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(collision.gameObject);
        }
    }
}
