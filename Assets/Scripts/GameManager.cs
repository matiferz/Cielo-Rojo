
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void PauseGame()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0;
        }
        
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }


}