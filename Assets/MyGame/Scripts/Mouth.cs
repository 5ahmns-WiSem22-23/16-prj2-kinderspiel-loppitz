using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mouth : MonoBehaviour
{
    [SerializeField] private GameObject foodOp1;
    [SerializeField] private GameObject foodOp2;
    [SerializeField] private GameObject foodOp3;
    [SerializeField] private GameObject foodOp4;

    [SerializeField] private int score = 0;
    [SerializeField] private Text scoreText;
    string s;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger entered");
        if (true)
        {
            Object.Destroy(collider.gameObject);

            score++;

        }
    }

    void Update()
    {
        s = score.ToString();
        scoreText.text = s;

        if (score == 4)
        {
            SceneManager.LoadScene("YouWon");
        }
    }
}
