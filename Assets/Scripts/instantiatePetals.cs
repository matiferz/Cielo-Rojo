using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class instantiatePetals : MonoBehaviour
{
    [SerializeField] private GameObject fallingPetal;

    
    //Lista para reunir todos los pétalos instanciados
    private List<GameObject> allPetals = new List<GameObject>();

    void FixedUpdate()
    { 


            GameObject newPetal = (GameObject) Instantiate (fallingPetal) as GameObject;
            float x = Random.Range (-30f, 30f);
            float y = Random.Range (-8f, 100f);
            newPetal.transform.position = new Vector2(x,y);
            allPetals.Add(newPetal);
   
             
        
    }

    public void destroyPetals()
    {
        foreach (GameObject petal in allPetals)
        {
            Destroy(petal);
        }
        allPetals.Clear();
    }
}
