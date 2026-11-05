using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuGameOver : MonoBehaviour
{
    public void ReiniciarJuego()
    {
        // 1. Descongelamos el tiempo
        Time.timeScale = 1f;

        // 2. Volvemos a cargar la escena actual en la que estamos
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}