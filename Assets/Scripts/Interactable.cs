using UnityEngine;

namespace StonesGaming
{
    public class Interactable : MonoBehaviour
    {
        public float radius = 0.6f;
        public string interactableText;

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, radius);
        }

        public virtual void Interact(PlayerManager playerManager)
        {
            Debug.Log("You interacted with an object!");
        }
    }
}