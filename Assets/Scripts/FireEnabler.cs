using UnityEngine;

public class FireEnabler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var fire = gameObject.GetComponentInChildren<Transform>().Find("Fire");
            fire.gameObject.SetActive(true);
        }
    }
}
