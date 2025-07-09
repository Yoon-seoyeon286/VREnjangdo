using UnityEngine;

public class EnemtSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyObject;

    void Start()
    {
        
    }


    void Update()
    {
        if (GameManager.instance.enemyLive == false)
        {
            int index = Random.Range(0, spawnPoint.Length);
            Instantiate(enemyObject, spawnPoint[index].position, spawnPoint[index].rotation);
            GameManager.instance.enemyLive = true;
        }


    }
}
