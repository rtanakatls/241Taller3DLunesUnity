using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    protected override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * Time.deltaTime * 90, 0);
        rb.velocity = new Vector3(transform.forward.x * vertical * speed, rb.velocity.y, transform.forward.z * vertical * speed);
    }
}
