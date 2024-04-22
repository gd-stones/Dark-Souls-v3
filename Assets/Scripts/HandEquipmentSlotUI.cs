using UnityEngine;
using UnityEngine.UI;

namespace StonesGaming
{
    public class HandEquipmentSlotUI : MonoBehaviour
    {
        public Image icon;
        WeaponItem weapon;

        public bool rightHandSlot01;
        public bool rightHandSlot02;
        public bool leftHandSlot01;
        public bool leftHandSlot02;

        public void AddItem(WeaponItem newWeapon)
        {
            weapon = newWeapon;
            icon.sprite = weapon.itemIcon;
            icon.enabled = true;
            gameObject.SetActive(true);
        }


        public void ClearItem()
        {
            if (weapon == null)
                return;

            weapon = null;
            icon.sprite = null;
            icon.enabled = false;
            gameObject.SetActive(false); 
        }
    }
}