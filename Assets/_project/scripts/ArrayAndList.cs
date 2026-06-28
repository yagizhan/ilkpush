using System;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndList : MonoBehaviour
{
    public Enemy enemyPreFabs;
    public int enemyCaount;
    public List<Enemy> enemies;
    public int spacing;

    private void Start()
    {

        for (int i = 0; i < enemyCaount; i++)
        {
            /*for (int j = 0; j < enemyCaount; j++)
            {
                var newEneemy = Instantiate(enemyPreFabs);
                newEneemy.transform.position
                    = new Vector3(j * spacing, 0, i * spacing);
                enemies.Add(newEneemy);
            }*/
            SpawnEnemy();
        }
        var j = 0;
        while (j < enemyCaount)
        {
            SpawnEnemy();
            j++;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (var e in enemies)
            {
                e.transform.position += Vector3.up;
            }
        }



    }

    private void SpawnEnemy()
    {
        var newEneemy = Instantiate(enemyPreFabs);
        newEneemy.transform.position
            = new Vector3(UnityEngine.Random.Range(-5f, 5f), 0, UnityEngine.Random.Range(-5f, 5f));
        enemies.Add(newEneemy);
    }
}
