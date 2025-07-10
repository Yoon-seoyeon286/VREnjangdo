using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject prefabEffect;
    public Transform swordSpawn;
    public bool swordReal;

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
    }


    void swordDestroy()
    {
        Destroy(gameObject);
    }
}
