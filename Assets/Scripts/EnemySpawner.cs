using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    private float timer;

    private void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GameObject obj = Instantiate(enemies[Random.Range(0, enemies.Count)]);
            obj.transform.position = transform.position;
            timer = 0;
        }
    }
}
