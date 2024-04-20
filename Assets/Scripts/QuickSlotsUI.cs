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
                rightWeaponItem.sprite = weapon.itemIcon;

                if (rightWeaponItem.sprite != null)
                {
                    rightWeaponItem.enabled = true;
                }
                else
                {
                    rightWeaponItem.enabled = false;
                }
            }
            else
            {
                leftWeaponItem.sprite = weapon.itemIcon;

                if (leftWeaponItem.sprite != null)
                {
                    leftWeaponItem.enabled = true;
                }
                else
                {
                    leftWeaponItem.enabled = false;
                }
            }
        }
    }
}