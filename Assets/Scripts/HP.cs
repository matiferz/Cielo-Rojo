using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] private float HPAmount; // Variable de cantidad de puntos de salud, que se irá actualizando
    [SerializeField] private float MaxHP; // Variable de cantidad máxima de puntos de salud
    [SerializeField] private HPBar hpbar; // Referencia a la clase HPBar que construiremos a la par

    // Referencia al script que controla el parpadeo del Player
    private PlayerDamageFlash damageFlash;
    public AudioSource audioSource;
    public AudioClip clipDanio;

    // NUEVO: Variable para asignar el panel de Game Over
    public GameObject pantallaGameOver;

    private void Start()
    {
        HPAmount = MaxHP; // Inicializamos la variable HPAmount con el valor máximo

        HPBar.Instance.InitializeHPBar(HPAmount); // Inicializamos la barra visual

        // Obtenemos el componente PlayerDamageFlash del avión
        damageFlash = GetComponent<PlayerDamageFlash>();
    }

    public void TakeDamage(int damage) // Código para recibir daño
    {
        HPAmount -= damage; // Restamos la salud

        HPBar.Instance.ChangeCurrentHP(HPAmount); // Actualizamos la interfaz

        // Reproducimos el sonido de recibir daño
        audioSource.PlayOneShot(clipDanio);

        
        if (damageFlash != null)
        {
            damageFlash.Parpadear();
        }

        
        if (HPAmount <= 0)
        {
            Die();
        }
    }

    public void GainHealth(int health) // Código para ganar salud
    {
        HPAmount += health;
        HPBar.Instance.ChangeCurrentHP(HPAmount);
    }

    private void Die()
    {
        if (pantallaGameOver != null)
        {
            pantallaGameOver.SetActive(true); // Enciende la pantalla de Game Over
        }

        Time.timeScale = 0f; // Congela el tiempo para que los enemigos y el fondo paren
        Destroy(gameObject); // Destruye el objeto del Player
    }
}
