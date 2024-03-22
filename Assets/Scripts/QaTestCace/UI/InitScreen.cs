using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

namespace QaTestCace.UI
{
    public class InitScreen : MonoBehaviour
    {
        private const string SCENE_NAME = "GameScene";
        public Button startButton;

        private void Start()
        {
            startButton.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene(SCENE_NAME);

        }

        private void OnDestroy()
        {
            startButton.onClick.RemoveListener(OnButtonClick);
        }
    }
}