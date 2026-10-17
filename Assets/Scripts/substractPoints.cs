using UnityEngine;


public class substractPoints : MonoBehaviour
{
    public int pointsToSubstract; // La cantidad de puntos a restar por cada colisión


    void OnCollisionEnter2D(Collision2D other) // Qué va a suceder cuando el personaje colisione con el enemigo u objeto?
    {
        if (other.gameObject.tag == "Player") // Primero le pedimos que se fije que el elemento con el que colisiona tiene la etiqueta de Player
        {
            PointSytem.Instance.SubstractingPoints(pointsToSubstract); // Si colisiona, le resta los puntos según la función "SubstractingPoints" de la clase "PointSystem". Le va a restar según la cantidad que indicamos en la variable arriba mencionada.
            other.gameObject.GetComponent<HP>().TakeDamage(1); // Va a llamar al componente del objeto con el que colisiona, es decir, el Player. El componente al que llama es el script "HP", donde tenemos el método de recibir daño.
        }
    }
}


// Nótese que estamos pensando en una colisión que no es trigger. Si la colisión es con un colisionador trigger, la sintaxis cambia.
