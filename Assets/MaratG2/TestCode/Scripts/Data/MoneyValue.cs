using System;
using MaratG2.Extensions;
using UnityEngine;

namespace MaratG2.TestCode.Data
{
    public class MoneyValue : MonoBehaviour
    {
        public ulong Value { get; private set; } = 1;
        private CharacterEquipment _characterEquipment;

        private void Awake()
        {
            _characterEquipment = FindObjectOfType<CharacterEquipment>();
            if(_characterEquipment == null)
                UnityExceptions.RaiseTagged(new NullReferenceException(), nameof(_characterEquipment));
        }

        private void Start()
        {
            UpdateMoneyValueFromWeaponChange(_characterEquipment.CurrentWeapon);
        }

        private void OnEnable()
        {
            _characterEquipment.OnWeaponChanged += UpdateMoneyValueFromWeaponChange;
        }
        private void OnDisable()
        {
            _characterEquipment.OnWeaponChanged -= UpdateMoneyValueFromWeaponChange;
        }
        
        private void UpdateMoneyValueFromWeaponChange(Weapon newWeapon)
        {
            if(newWeapon == null)
            {
                UnityExceptions.RaiseTagged(new ArgumentNullException(), nameof(newWeapon));
                return;
            }
            
            Value = newWeapon.WeaponValue;
        }
    }
}