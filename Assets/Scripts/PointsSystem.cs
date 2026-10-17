using UnityEngine;
using TMPro; // Es importante ponerlo para poder acceder a todas las cuestiones relacionadas al texto en interfaz y su personalización


public class PointSytem : MonoBehaviour
{
    public static PointSytem Instance; // Creamos la instancia
    public TextMeshProUGUI textPoints; // Es el elemento que vamos a utilizar para visualizar los puntos
    private int points = 0; // El número inicial de puntos


    public void AddingPoints(int quantity)
    {
        points += quantity;
        UpdateUI();
    }


    // Con AddingPoints le estamos pidiendo a la interfaz que actualice la información de la UI en pantalla, según la suma de la cantidad de puntos


    public void SubstractingPoints(int quantity)
    {
        points -= quantity;
        UpdateUI();
    }


    // Hacemos lo mismo, pero restando


    private void UpdateUI()
    {
        if (points < 0)
        {
            points = 0;
        }


        textPoints.text = "SCORE: " + points.ToString();
    }


    // Esta es la función clave para que los datos se actualicen en la pantalla.
    // En la última línea invocamos a la variable textPoints de arriba, y escribimos sobre ella "Points: ". Se van a buscar los números del puntaje y se irán actualizando constantemente.
    // En el "if" Le estamos diciendo que si el conteo de puntos nos da menos a 0, que no siga contando en números negativos sino que continúe mostrando 0



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
