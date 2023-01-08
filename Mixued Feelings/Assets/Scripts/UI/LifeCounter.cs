using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LifeCounter : MonoBehaviour
{

    // Gameplay
    public int numberOfLives;

    // Visuals
    public GameObject LifePrefab;
    public GameObject scoreText;
    public GameObject gameOverGroup;
    public GameObject highScoreGroup;
    
    private List<GameObject> lives;

    // Start is called before the first frame update
    void Start() {

        gameOverGroup.SetActive(false);
        highScoreGroup.SetActive(false);

        lives = new List<GameObject>();
        for (int i = 0; i < numberOfLives; i++) {
            GameObject lifeInstance = Instantiate (LifePrefab, transform);
            lives.Add(lifeInstance);
        }

    }

    public void LoseLife() {

        numberOfLives--;

        GameObject lastLife = lives[lives.Count - 1];
        lives.Remove(lastLife);

        Destroy(lastLife);

        if (numberOfLives <= 0) {
            
            Debug.Log("Game Over!");

            gameOverGroup.SetActive(true);
            TMP_Text gameOverText = gameOverGroup.GetComponentInChildren<TMP_Text>();
            int score = GameObject.Find("ScoreText").GetComponent<ScoreText>().Score;

            int highscore = PlayerPrefs.GetInt("highscore", 0);
            if (score > highscore) {
                PlayerPrefs.SetInt("highscore", score);
            }
            // int score = PlayerPrefs.GetInt("score");
            gameOverText.text = string.Format(gameOverText.text, score);

            highScoreGroup.SetActive(true);
            TMP_Text highScoreText = highScoreGroup.GetComponentInChildren<TMP_Text>();
            highScoreText.text = string.Format(highScoreText.text, highscore);

            scoreText.SetActive(false);

        }

    }
    
    void Update() {

        if (numberOfLives <=0 && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("Main");
        }

    }

}
