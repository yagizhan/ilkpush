using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameDirector gameDirector;
    public List<Enemy> enemies;
    public Enemy enemyPreFab;
    public void GenerateEnemies()
    {
        for (int i = 0; i < 10; i++)
        {
            CreateEnemy();
        }

    }

    public void EnemyDestroyed(Enemy enemy)
    {
        enemies.Remove(enemy);
        if (enemies.Count==0)
        {
            gameDirector.LevelCleared();
        }
    }

    private void CreateEnemy()
    {
        var enemy = Instantiate(enemyPreFab);
        enemy.transform.position 
            = new Vector3(UnityEngine.Random.Range(-5f, 5f), 0, UnityEngine.Random.Range(-5f, 5f));
        enemies.Add(enemy);
        enemy.StartEnemy(this);
    }
}
