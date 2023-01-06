// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;
// using TMPro;

// public class GameSceneController : MonoBehaviour
// {

//     // Gameplay
//     public int numberOfLives;
//     public ObjectSpawner fruitSpawner;
//     public ObjectSpawner bombSpawner;
    
//     // Interface
//     public TextMeshProUGUI scoreText;
//     public LifeCounter LifeCounter;
//     public GameObject gameOverGroup;
    
//     private int score = 0;
//     public int Score {
//         get { return score; }
//         set {
//             score = value;
//             scoreText.SetText("Score: " + score);
//         }
//     }

//     void Start() {

//         gameOverGroup.SetActive(false);

//         LifeCounter.SetLives(numberOfLives);

//         fruitSpawner.OnObjectSpawned += OnObjectSpawned;
//         bombSpawner.OnObjectSpawned += OnObjectSpawned;

//         Score = 0;

//     }

//     void Update() {

//         if (numberOfLives <=0 && Input.GetMouseButtonDown(0)) {
//             SceneManager.LoadScene("Main");
//         }

//     }

//     private void OnObjectSpawned(CuttableObject obj) {

//         obj.OnDestroyed += OnObjectDestroyed;

//     }
 
//     private void OnObjectDestroyed (bool harmful) {

//         if (!harmful) {
//             Score += 10;
//             Debug.Log("Test");
//         } else {
//             LoseLife();
//         }

//     }

//     private void LoseLife() {

//         numberOfLives--;

//         LifeCounter.LoseLife();

//         if (numberOfLives <= 0) {

//             scoreText.gameObject.SetActive(false);
//             gameOverGroup.SetActive(true);

//             // Update Text
//             TMP_Text gameOverText = gameOverGroup.GetComponentInChildren<TMP_Text>();
//             gameOverText.text = string.Format(gameOverText.text, score);

//         }
//     }
// }
