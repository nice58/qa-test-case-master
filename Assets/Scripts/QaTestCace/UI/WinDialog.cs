using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace QaTestCace.UI
{
    public class WinDialog: MonoBehaviour
    {
        private const string SceneName = "StartScene";
        public Button restartButton;

        private void OnEnable()
        {
            restartButton.onClick.AddListener(OnRestartButtonClick);
        }

        private void OnRestartButtonClick()
        {
            SceneManager.LoadScene(SceneName);
        }

        private void OnDisable()
        {
            restartButton.onClick.RemoveListener(OnRestartButtonClick);
        }
        
        
    }
}