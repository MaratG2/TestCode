using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaratG2.TestCode.Datas
{
    public class MoneyValue : MonoBehaviour
    {
        public ulong Value { get; private set; } = 1;
        private CharacterEquipment _characterEquipment;

        private void Awake()
        {
            _characterEquipment = FindObjectOfType<CharacterEquipment>();
        }

        private void Start()
        {
            UpdateMoneyValue();
        }

        private void OnEnable()
        {
            _characterEquipment.OnWeaponChanged += UpdateMoneyValue;
        }
        private void OnDisable()
        {
            _characterEquipment.OnWeaponChanged -= UpdateMoneyValue;
        }
        
        private void UpdateMoneyValue()
        {
            Value = _characterEquipment.CurrentWeapon.WeaponValue;
        }
    }
}