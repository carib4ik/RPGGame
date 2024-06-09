using UnityEngine;

public class PickUpPotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Outline>();
            player.OutlineWidth = 2;
            
            Destroy(gameObject);
        }
    }
}
