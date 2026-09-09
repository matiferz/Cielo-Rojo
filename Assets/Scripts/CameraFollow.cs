using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float suavizado = 5f;

    public float limiteIzquierdo = -4f;
    public float limiteDerecho = 4f;
    public float limiteInferior = -2f;
    public float limiteSuperior = 2f;

    private float posicionZ;

    void Start()
    {
        posicionZ = transform.position.z;
    }

    void LateUpdate()
    {
        if (player == null)
            return;

        float nuevaX = Mathf.Clamp(
            player.position.x,
            limiteIzquierdo,
            limiteDerecho
        );

        float nuevaY = Mathf.Clamp(
            player.position.y,
            limiteInferior,
            limiteSuperior
        );

        Vector3 posicionObjetivo = new Vector3(
            nuevaX,
            nuevaY,
            posicionZ
        );

        transform.position = Vector3.Lerp(
            transform.position,
            posicionObjetivo,
            suavizado * Time.deltaTime
        );
    }
}