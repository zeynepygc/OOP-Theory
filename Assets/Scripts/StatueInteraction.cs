using UnityEngine;

public class StatueInteraction : MonoBehaviour
{
    private TempleStatue templeStatue;
    private bool playerNearby = false;

    void Start()
    {
        templeStatue = GetComponentInParent<TempleStatue>();
    }

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            if (templeStatue != null)
            {
                templeStatue.Interact();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}