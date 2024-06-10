using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement
{
    [SerializeField] private Vector3 direction;
    private ObjectCheckpoint obj;
    protected override void Move()
    {
        rb.velocity = new Vector3(direction.x*speed, rb.velocity.y, direction.z * speed) ;
    }

    public void SetObjectCheckpoint(ObjectCheckpoint obj)
    {
        this.obj = obj;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ChangeDirection"))
        {
            direction = new Vector3(-1, 0, 0);
        }
        else if (other.gameObject.CompareTag("Checkpoint"))
        {
            obj.CurrentCheckpoint=other.gameObject;
        }
    }
}
