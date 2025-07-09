using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject prefabEffect;
    public GameObject swordPrefab;
    public Transform swordSpawn;
    bool swordReal;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(prefabEffect, transform.position, transform.rotation);
            Invoke("swordDestroy", 2.5f);
            swordReal = false;
        }

        if (swordReal == false)
        {
            Instantiate(swordPrefab, swordSpawn.position, swordSpawn.rotation);
            swordReal = true;
        }
    }


    void swordDestroy()
    {
        Destroy(gameObject);
    }
}
