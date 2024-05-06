using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuicideMovement : EnemyMovement
{
    protected Transform playerTransform;

    protected override void Initialize()
    {
        base.Initialize();
        playerTransform = GameObject.Find("Player").transform;
    }

    protected override void Move()
    { 
        Vector3 direction=playerTransform.position - transform.position;
        direction.y = 0;
        direction=direction.normalized;
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
    }
}
