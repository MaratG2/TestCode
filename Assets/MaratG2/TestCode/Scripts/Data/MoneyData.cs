using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaratG2.TestCode.Data
{
    [RequireComponent(typeof(MoneyValue))]
    public class MoneyData : MonoBehaviour
    {
        public ulong Money { get; private set; }
        private MoneyValue _moneyValue;

        private void Awake()
        {
            _moneyValue = GetComponent<MoneyValue>();
        }
        public void HandleClickInterface()
        {
            HandleClick();
        }

        private void HandleClick()
        {
            Money += _moneyValue.Value;
            Debug.Log($"Total: {Money}, hit: {_moneyValue.Value}");
        }
    }
}