using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MaratG2.TestCode.Handlers
{
    public class ClickTargetHandler : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public event Action OnClick;
        public event Action OnEnter;
        public event Action OnExit;

        public void OnPointerDown(PointerEventData eventData)
        {
            OnClick?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnEnter?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnExit?.Invoke();
        }
    }
}