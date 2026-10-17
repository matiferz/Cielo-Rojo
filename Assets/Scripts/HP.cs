using UnityEngine;


public class HP : MonoBehaviour
{
    [SerializeField] private float HPAmount; // Variable de cantidad de puntos de salud, que se irá actualizando
    [SerializeField] private float MaxHP; // Variable de cantidad máxima de puntos de salud
    [SerializeField] private HPBar hpbar; // Referencia a la clase HPBar que construiremos a la par

    private void Start()
    {
        HPAmount = MaxHP; // Inicializamos la variable HPAmount con el valor máximo (dado que vamos a buscar restarle)
        HPBar.Instance.InitializeHPBar(HPAmount);// De la clase "HPBar" traemos la función de inicialización de la barra, la misma va a cargarse con la cantidad inicial de HP, correspondiéndose con lo de arriba
    }


    public void TakeDamage(int damage) // Código para recibir daño
    {
        HPAmount -= damage; // Actualizamos la cantidad de HP según el daño que nos hacen aka la salud que nos quitan
        HPBar.Instance.ChangeCurrentHP(HPAmount); // Actualizamos ese dato en la interfaz visual
    }


    public void GainHealth(int health) // Código para ganar salud, funciona de igual manera que arriba pero suma en vez de restar
    {
        HPAmount += health;
        HPBar.Instance.ChangeCurrentHP(HPAmount);
    }
}

