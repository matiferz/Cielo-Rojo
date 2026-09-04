using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float suavizado = 5f;

    private float posicionY;
    private float posicionZ;

    void Start()
    {
        posicionY = transform.position.y;
        posicionZ = transform.position.z;
    }

    void LateUpdate()
    {
        if (player == null)
            return;

        Vector3 posicionObjetivo = new Vector3(
            player.position.x,
            posicionY,
            posicionZ
        );

        transform.position = Vector3.Lerp(
            transform.position,
            posicionObjetivo,
            suavizado * Time.deltaTime
        );
    }
}