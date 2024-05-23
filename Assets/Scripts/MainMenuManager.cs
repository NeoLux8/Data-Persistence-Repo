using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public InputField nameInputField;
    public Text highestScoreText; // Text field to display highest score and player name

    private void Start()
    {
        // Retrieve and display the highest score and player name
        int highestScore = PlayerPrefs.GetInt("HighestScore", 0);
        string highestScorePlayerName = PlayerPrefs.GetString("HighestScorePlayerName", "Player");

        highestScoreText.text = $"Highest Score: {highestScore} by {highestScorePlayerName}";
    }

    public void StartGame()
    {
        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene(1);
    }
}