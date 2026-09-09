using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;

    public float limiteIzquierdo = -5f;
    public float limiteDerecho = 5f;
    public float limiteInferior = -3f;
    public float limiteSuperior = 3f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimientoX = Input.GetAxisRaw("Horizontal");
        float movimientoY = Input.GetAxisRaw("Vertical");

        movimiento = new Vector2(movimientoX, movimientoY).normalized;
    }

    void FixedUpdate()
    {
        Vector2 nuevaPosicion =
            rb.position + movimiento * speed * Time.fixedDeltaTime;

        nuevaPosicion.x = Mathf.Clamp(
            nuevaPosicion.x,
            limiteIzquierdo,
            limiteDerecho
        );

        nuevaPosicion.y = Mathf.Clamp(
            nuevaPosicion.y,
            limiteInferior,
            limiteSuperior
        );

        rb.MovePosition(nuevaPosicion);
    }
}