using System;
using JetBrains.Annotations;
using MaratG2.TestCode.Data;
using TMPro;
using UnityEngine;

namespace MaratG2.TestCode.View
{
    public class MoneyView : MonoBehaviour
    {
        [NotNull, SerializeField] private TextMeshProUGUI _moneyCounter;
        private MoneyData _moneyData;
        
        private void Awake()
        {
            _moneyData = FindObjectOfType<MoneyData>();
            
            if(_moneyData == null)
                Debug.LogError(new NullReferenceException(nameof(_moneyData)));
        }

        private void OnEnable()
        {
            _moneyData.OnMoneyChanged += UpdateUI;
        }
        
        private void OnDisable()
        {
            _moneyData.OnMoneyChanged -= UpdateUI;
        }
        
        private void UpdateUI()
        {
            _moneyCounter.text = $"${_moneyData.Money.ToString()}";
        }
    }
}