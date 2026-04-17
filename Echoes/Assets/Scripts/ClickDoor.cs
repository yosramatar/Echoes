using UnityEngine;

public class ClickableDoor : MonoBehaviour
{
    public float interactDistance = 2f;
    public Transform player;
    public GameObject lockedMessage;

    void OnMouseDown()
    {
        if (player == null) return;

        float distance = Vector2.Distance(player.position, transform.position);

        if (distance <= interactDistance)
        {
            if (GameManager.instance != null && GameManager.instance.hasKey)
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

    void OnMouseExit()
    {
        if (lockedMessage != null)
            lockedMessage.SetActive(false);
    }
}