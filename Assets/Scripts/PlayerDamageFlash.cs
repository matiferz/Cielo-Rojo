using System.Collections;
using UnityEngine;

public class PlayerDamageFlash : MonoBehaviour
{
    [SerializeField] private float duracion = 1f;
    [SerializeField] private float intervalo = 0.1f;

    private SpriteRenderer spriteRenderer;
    private Coroutine parpadeoActual;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Parpadear()
    {
        if (parpadeoActual != null)
        {
            StopCoroutine(parpadeoActual);
        }

        parpadeoActual = StartCoroutine(EfectoParpadeo());
    }

    private IEnumerator EfectoParpadeo()
    {
        float tiempo = 0f;

        while (tiempo < duracion)
        {
            spriteRenderer.enabled = false;

            yield return new WaitForSeconds(intervalo);

            spriteRenderer.enabled = true;

            yield return new WaitForSeconds(intervalo);

            tiempo += intervalo * 2f;
        }

        spriteRenderer.enabled = true;
        parpadeoActual = null;
    }

    private void OnDisable()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = true;
        }
    }
}