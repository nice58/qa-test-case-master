using System;
using QaTestCace.Controller;
using UnityEngine;
using UnityEngine.UI;

namespace QaTestCace.UI
{
    public class GameScreen : MonoBehaviour
    {
        public Button jumpButton;

        public CustomButton upButton;
        public CustomButton downButton;
        public CustomButton leftButton;
        public CustomButton rightButton;

        public GameObject winDialog;

        public PlayerController playerController;
        public BoxController boxController;

        private void Start()
        {
            jumpButton.onClick.AddListener(OnJump);
            upButton.OnDown += OnUp;
            upButton.OnUp += OnReleaseUp;

            downButton.OnDown += OnDown;
            downButton.OnUp += OnReleaseUp;

            leftButton.OnDown += OnLeft;
            leftButton.OnUp += OnReleaseLeft;

            rightButton.OnDown += OnRight;
            rightButton.OnUp += OnReleaseLeft;

            boxController.OnSuccess += OnWin;
        }

        private void OnWin()
        {
            winDialog.SetActive(true);
            
            RemoveListeners();
            playerController.SetHorizontal(0);
            playerController.SetVertical(0);
        }

        private void OnReleaseLeft()
        {
            playerController.SetHorizontal(0);
        }

        private void OnReleaseUp()
        {
            playerController.SetVertical(0);
        }

        private void OnDestroy()
        {
            RemoveListeners();
        }

        private void RemoveListeners()
        {
            jumpButton.onClick.RemoveListener(OnJump);
            upButton.OnDown -= OnUp;
            upButton.OnUp -= OnReleaseUp;

            downButton.OnDown -= OnUp;
            downButton.OnUp -= OnReleaseUp;

            leftButton.OnDown -= OnLeft;
            leftButton.OnUp -= OnReleaseLeft;

            rightButton.OnDown -= OnRight;
            rightButton.OnUp -= OnReleaseLeft;

            boxController.OnSuccess -= OnWin;
        }

        private void OnRight()
        {
            playerController.SetHorizontal(1);
        }

        private void OnLeft()
        {
            playerController.SetHorizontal(-1);
        }

        private void OnDown()
        {
            playerController.SetVertical(-1);
        }

        private void OnUp()
        {
            playerController.SetVertical(1);
        }

        private void OnJump()
        {
            playerController.Jump();
        }
    }
}