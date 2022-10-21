using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScore;
    Text txSelamat;
    int highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS", 0);
        if (Data.score > highscore)
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("HS", highscore);
        }
        else if (EnemyController.EnemyKilled == 3)
        {
            SceneManager.LoadScene("Congratulations");
        }
        HighScore.text = "Highscores: " + highscore;
        Score.text = "Scores: " + Data.score;
    }

    public void Replay()
    {
        Data.score = 0;
        EnemyController.EnemyKilled = 0;
        SceneManager.LoadScene("Gameplay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
