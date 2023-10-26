using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player && collision.CompareTag("Player"))
        {
            // Respawn du joueur à la position du respawnPoint
            Player.transform.position = respawnPoint.position;
        }
    }
}
