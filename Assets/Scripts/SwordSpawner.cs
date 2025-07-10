using UnityEngine;

public class SwordSpawner : MonoBehaviour
{
    Sword sword;
    public GameObject swordPrefab;
    public Transform swordSpawner;


    void Start()
    {
        sword = FindAnyObjectByType<Sword>();   
    }


    void Update()
    {
        if (sword.swordReal == false)
        {
            Instantiate(swordPrefab, swordSpawner.position, swordSpawner.rotation);
        }
        
    }
}
