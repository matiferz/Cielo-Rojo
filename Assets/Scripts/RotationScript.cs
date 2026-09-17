using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float rotationSpeed = 720f;

    private Rigidbody2D rb;
    private Vector2 movementInput;
    private Animator animator;

    [SerializeField] private float left = -0.8f;
    [SerializeField] private float right = 0.8f;
    [SerializeField] private float bottom = -0.8f;
    [SerializeField] private float top = 0.8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movementInput = new Vector2(horizontal, vertical).normalized;

        if (movementInput.sqrMagnitude > 0.01f)
        {
            float targetAngle =
                Mathf.Atan2(movementInput.y, movementInput.x) * Mathf.Rad2Deg;

            Quaternion targetRotation =
                Quaternion.Euler(0f, 0f, targetAngle - 90f);

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime
            );
        }

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Shoot");
        }
    }

    void FixedUpdate()
    {
        Vector2 nuevaPosicion =
            rb.position + movementInput * speed * Time.fixedDeltaTime;

        if (nuevaPosicion.x < left)
        {
            nuevaPosicion.x = left;
        }

        if (nuevaPosicion.x > right)
        {
            nuevaPosicion.x = right;
        }

        if (nuevaPosicion.y < bottom)
        {
            nuevaPosicion.y = bottom;
        }

        if (nuevaPosicion.y > top)
        {
            nuevaPosicion.y = top;
        }

        rb.MovePosition(nuevaPosicion);
    }
}