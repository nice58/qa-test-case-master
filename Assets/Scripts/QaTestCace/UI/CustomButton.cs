using Unity.VisualScripting;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace QaTestCace.UI
{
    public class CustomButton : Button
    {
        public event UnityAction OnDown;
        public event UnityAction OnUp;

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            OnDown?.Invoke();
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            OnUp?.Invoke();
        }
    }
}