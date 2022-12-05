using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaratG2.TestCode.Data
{
    [RequireComponent(typeof(MoneyValueData))]
    public class MoneyData : MonoBehaviour
    {
        public ulong Money { get; private set; }
        public event Action OnMoneyChanged;
        private MoneyValueData _moneyValue;

        private void Awake()
        {
            _moneyValue = GetComponent<MoneyValueData>();
        }
        public void HandleClickInterface()
        {
            HandleClick();
            OnMoneyChanged?.Invoke();
        }

        private void HandleClick()
        {
            Money += _moneyValue.Value;
        }
    }
}