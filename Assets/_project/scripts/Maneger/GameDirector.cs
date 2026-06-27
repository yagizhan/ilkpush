using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public EnemyManager enemyManager;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        enemyManager.GenerateEnemies();
    }

    public void LevelCleared()
    {
        enemyManager.GenerateEnemies();
    }
}
