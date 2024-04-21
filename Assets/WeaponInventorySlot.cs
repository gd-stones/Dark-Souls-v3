using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace StonesGaming
{
    public class WeaponInventorySlot : MonoBehaviour
    {
        public Image icon;
        WeaponItem item;

        public void AddItem(WeaponItem newItem)
        {
            item = newItem;
            icon.sprite = item.itemIcon;
            icon.enabled = true;
            gameObject.SetActive(true);
        }

        public void ClearInventorySlot()
        {
            if (item == null)
                return;

            icon = null;
            icon.sprite = null;
            icon.enabled = false;
            gameObject.SetActive(false);
        }
    }
}