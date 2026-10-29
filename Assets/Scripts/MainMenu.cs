using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jugar()
    {
        // Restauramos el tiempo del juego
        Time.timeScale = 1f;

        // Reiniciamos la puntuación
        Score.score = 0;

        // Cargamos la escena del juego
        SceneManager.LoadScene("Nivel 1");
    }

    public void Salir()
    {
        // Cerramos el juego
        Application.Quit();

        Debug.Log("Saliendo del juego...");
    }
}