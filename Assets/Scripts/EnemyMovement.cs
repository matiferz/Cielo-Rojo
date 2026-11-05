using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    private Transform player;

    void Start()
    {
        // El enemigo busca automáticamente el objeto que tenga el Tag "Player"
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        // Si el jugador está vivo en la escena, nos movemos hacia él
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            // Si el jugador fue destruido, los enemigos siguen volando recto hacia abajo
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}