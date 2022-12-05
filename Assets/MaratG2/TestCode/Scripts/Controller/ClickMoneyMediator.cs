using System;
using MaratG2.Extensions;
using MaratG2.TestCode.Data;
using UnityEngine;

namespace MaratG2.TestCode.Controller
{
    public class ClickMoneyMediator : MonoBehaviour
    {
        private ClickTargetController _clickTargetController;
        private MoneyData _moneyData;

        private void Awake()
        {
            _clickTargetController = FindObjectOfType<ClickTargetController>();
            if (_clickTargetController == null)
                Debug.LogError(UnityExceptions.CreateException(Exceptions.NullReferenceException,
                    nameof(_clickTargetController)));
            
            _moneyData = FindObjectOfType<MoneyData>();
            if (_moneyData == null)
                Debug.LogError(UnityExceptions.CreateException(Exceptions.NullReferenceException,
                    nameof(_moneyData)));
        }

        private void OnEnable()
        {
            _clickTargetController.OnClick += _moneyData.HandleClickInterface;
        }

        private void OnDisable()
        {
            _clickTargetController.OnClick -= _moneyData.HandleClickInterface;
        }
    }
}