using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody2D rb;
    private float horizontalInput;

    private Camera cam;
    private float mitadAnchoPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        mitadAnchoPlayer = spriteRenderer.bounds.extents.x;
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        float nuevaX =
            rb.position.x +
            horizontalInput * speed * Time.fixedDeltaTime;

        float distanciaCamara =
            Mathf.Abs(cam.transform.position.z - transform.position.z);

        Vector3 bordeIzquierdo =
            cam.ViewportToWorldPoint(
                new Vector3(0f, 0.5f, distanciaCamara)
            );

        Vector3 bordeDerecho =
            cam.ViewportToWorldPoint(
                new Vector3(1f, 0.5f, distanciaCamara)
            );

        float limiteIzquierdo =
            bordeIzquierdo.x + mitadAnchoPlayer;

        float limiteDerecho =
            bordeDerecho.x - mitadAnchoPlayer;

        nuevaX = Mathf.Clamp(
            nuevaX,
            limiteIzquierdo,
            limiteDerecho
        );

        rb.MovePosition(
            new Vector2(nuevaX, rb.position.y)
        );
    }
}