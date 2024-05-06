using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement
{
    protected override void Move()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 1 * speed) ;
    }
}
