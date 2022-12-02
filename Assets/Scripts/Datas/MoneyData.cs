using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MaratG2.TestCode.Handlers;

namespace MaratG2.TestCode.Datas
{
    [RequireComponent(typeof(MoneyValue))]
    public class MoneyData : MonoBehaviour
    {
        public ulong Money { get; private set; }
        
        private ClickTargetHandler _clickTargetHandler;
        private MoneyValue _moneyValue;

        private void Awake()
        {
            _clickTargetHandler = FindObjectOfType<ClickTargetHandler>();
            _moneyValue = GetComponent<MoneyValue>();
        }
        private void OnEnable()
        {
            _clickTargetHandler.OnClick += HandleClick;
        }
        private void OnDisable()
        {
            _clickTargetHandler.OnClick -= HandleClick;
        }
        private void HandleClick()
        {
            Money += _moneyValue.Value;
            Debug.Log($"Total: {Money}, hit: {_moneyValue.Value}");
        }
    }
}