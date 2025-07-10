using UnityEngine;

public class Dummy : MonoBehaviour
{
    Animator animator;
    GameManager gameManager;

    int attackCount = 0;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        attackCount = 0;
    }

   
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Sword" )
        {
            animator.SetTrigger("Attack");
            GameManager.instance.addScore(5);
            attackCount++;
            GameManager.instance.enemyCount--;

            if (attackCount > 3)
            {
                animator.SetTrigger("Dead");
                Invoke("dummyDestroy", 3f);
            }
        }
    }

    void dummyDestroy()
    {
        Destroy(gameObject);
    }
}
