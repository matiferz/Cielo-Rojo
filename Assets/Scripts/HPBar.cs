using UnityEngine;
using UnityEngine.UI; // Ojo acá, necesitamos utilizar las librerías de UI de Unity


public class HPBar : MonoBehaviour
{
    public static HPBar Instance; // Esta es la instancia a la que referimos en el código HP

    private Slider slider; // Nuestro slider al que vamos a manipular con el código


    public void ChangeMaxHP(float MaxHP)
    {
        slider.maxValue = MaxHP; // En el inspector, esto va a reflejarse con el valor máximo que le fijamos, que se corresponderá con la cantidad máxima de HP
    }


    public void ChangeCurrentHP(float HPAmount)
    {
        slider.value = HPAmount; // En el inspector, esto va a reflejarse con el valor actual de HP
    }

    public void InitializeHPBar(float HPAmount)
    {
        slider = GetComponent<Slider>(); // Acá inicializamos la barra, la hacemos existir, por eso pedimos que nos traiga el componente
        ChangeMaxHP(HPAmount); // Le decimos que se inicialice la barra con el valor máximo en la función ChangeMaxHP
        ChangeCurrentHP(HPAmount); // Le pedimos que se actualice según el valor en la función ChangeCurrentHP
    }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}

