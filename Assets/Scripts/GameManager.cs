using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerNameText;
    public Text scoreText;
    public Text highestScoreText; // Add this field for displaying the highest score

    private int score = 0; // Assuming you keep track of score as an integer
    private bool m_GameOver = false;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = playerName;

        // Initialize the score display
        scoreText.text = "Score: " + score;

        // Initialize the highest score display
        int highestScore = PlayerPrefs.GetInt("HighestScore", 0);
        highestScoreText.text = "Highest Score: " + highestScore;
    }

    void Update()
    {
        if (!m_GameOver)
        {
            // Update the score continuously as per your game logic
            // For example, you might increment the score based on some conditions
            // score++;
            // scoreText.text = "Score: " + score;
        }
        else
        {
            // Game over logic
            CheckAndSetHighestScore();
        }
    }

    public void GameOver()
    {
        m_GameOver = true;
        CheckAndSetHighestScore();
    }

    private void CheckAndSetHighestScore()
    {
        int highestScore = PlayerPrefs.GetInt("HighestScore", 0);

        if (score > highestScore)
        {
            PlayerPrefs.SetInt("HighestScore", score);
            highestScoreText.text = "Highest Score: " + score;
        }
    }
}