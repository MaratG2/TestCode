using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaratG2.TestCode.Data
{
    public class CharacterEquipment : MonoBehaviour
    {
        public event Action OnWeaponChanged;
        private Weapon _currentWeapon;

        public CharacterEquipment()
        {
            CurrentWeapon = new DefaultWeapon();
        }

        public Weapon CurrentWeapon
        {
            get => _currentWeapon;
            private set
            {
                _currentWeapon = value;
                OnWeaponChanged?.Invoke();
            }
        }

        private void Start()
        {
            Invoke(nameof(TestTakeWoodenSword), 5f);
        }

        private void TestTakeWoodenSword()
        {
            CurrentWeapon = new WoodenSwordWeapon();
        }
    }
}