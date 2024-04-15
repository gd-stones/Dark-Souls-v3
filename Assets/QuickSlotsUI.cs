using UnityEngine;
using UnityEngine.UI;

namespace StonesGaming
{
    public class QuickSlotsUI : MonoBehaviour
    {
        public Image leftWeaponItem;
        public Image rightWeaponItem;

        public void UpdateWeaponQuickSlotsUI(bool isLeft, WeaponItem weapon)
        {
            if (isLeft == false)
            {
                if (rightWeaponItem != null)
                {
                    rightWeaponItem.sprite = weapon.itemIcon;
                    rightWeaponItem.enabled = true;
                }
                else
                {
                    rightWeaponItem.sprite = null;
                    rightWeaponItem.enabled = false;
                }
            }
            else
            {
                if (leftWeaponItem != null)
                {
                    leftWeaponItem.sprite = weapon.itemIcon;
                    leftWeaponItem.enabled = true;
                }
                else
                {
                    leftWeaponItem.sprite = null;
                    leftWeaponItem.enabled = true;
                }
            }
        }
    }
}