using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    int score = 0;
    int enemyCount = 0;
    public bool enemyLive;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        enemyCount = 3;
    }

    void Update()
    {
        if (enemyCount <= 0)
        {
            enemyLive = false;
        }
    }

    public void addScore(int newScore)
    {
        scoreText.text = "Á¡¼ö : " + newScore;
    }
}
