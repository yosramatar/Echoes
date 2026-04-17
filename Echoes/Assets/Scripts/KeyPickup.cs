using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject keyIcon;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.hasKey = true;

            if (keyIcon != null)
            {
                keyIcon.SetActive(true);
            }

            gameObject.SetActive(false);
            Debug.Log("Key collected");
        }
    }
}