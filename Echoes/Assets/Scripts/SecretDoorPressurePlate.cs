using UnityEngine;

public class ColumnPressurePlate : MonoBehaviour
{
    public GameObject secretDoor;
    private bool activated = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!activated && other.CompareTag("Player"))
        {
            activated = true;

            if (secretDoor != null)
            {
                secretDoor.SetActive(false);
            }

            Debug.Log("Pressure plate opened the door");
        }
    }
}