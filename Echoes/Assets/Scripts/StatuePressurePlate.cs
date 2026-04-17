using UnityEngine;

public class StatuePressurePlate : MonoBehaviour
{
    public GameObject celldoor;
    private bool activated = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!activated && other.CompareTag("Statue"))
        {
            activated = true;

            if (celldoor != null)
            {
                celldoor.SetActive(false);
            }

            Debug.Log("Door opened");
        }
    }
}