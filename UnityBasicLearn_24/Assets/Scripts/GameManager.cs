using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityBasic.Prototype2
{

    public class GameManager : MonoBehaviour
    {
        [Header("Singleton Pattern")]
        public static GameManager instance;


        [Header("UI �ý���")]
        public TextMeshProUGUI curScoreText;
        public TextMeshProUGUI bestScoreText;
        public int score;
        public int bestScore;

        [Header("Game Over")]
        public GameObject gameoverPanel;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
            {
                Destroy(instance);
            }
            DontDestroyOnLoad(gameObject);
        }
        void Start()
        {
            curScoreText.text = $"���� ���� : {score}";
            bestScoreText.text = $"�ְ� ���� : {bestScore}";
        }

        // Update is called once per frame
        void Update()
        {
            curScoreText.text = $"���� ���� : {score}";
            bestScoreText.text = $"�ְ� ���� : {bestScore}";

        }

        public void AddScore()
        {
            score += 100;
        }

        public void DecreaseScore() 
        { 
            score -= 100; 
        }

        public void GameOver()
        {
            gameoverPanel.SetActive(true);
        }

        public void GameQuit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }

        public void GameRestart()
        {
            SceneManager.LoadScene(0);
        }
    }
}
