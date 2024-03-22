using System;
using UnityEngine;
using UnityEngine.Events;

namespace QaTestCace.Controller
{
    public class BoxController : MonoBehaviour
    {
        public event UnityAction OnSuccess;

        private void OnTriggerEnter(Collider other)
        {
            OnSuccess?.Invoke();
        }
    }
}