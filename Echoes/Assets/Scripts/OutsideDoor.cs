using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public GameObject lockedMessage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.hasKey)
            {
                gameObject.SetActive(false);
                Debug.Log("Door opened with key");
            }
            else
            {
                if (lockedMessage != null)
                    lockedMessage.SetActive(true);

                Debug.Log("Door is locked");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (lockedMessage != null)
                lockedMessage.SetActive(false);
        }
    }
}