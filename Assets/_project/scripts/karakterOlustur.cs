using UnityEngine;

public class karakterOlustur : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemyPrefab;
    public Bullet bullet;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            var enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        }
        if (Input.GetMouseButtonDown(0))
        {
            var bullet1 = Instantiate(bullet,Vector3.zero,Quaternion.identity);
            
        }
    }
}
