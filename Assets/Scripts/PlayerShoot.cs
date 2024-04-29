using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform shootPoint;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.position = shootPoint.position;
            obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
        }
    }
}
