using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager_platformer : MonoBehaviour
{
    
    void Start()
    {
        //Aplicar script de la resolución
        Screen.SetResolution(1920, 1080, true);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Exit();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    void Exit()
    {
        Application.Quit();
    }
}

