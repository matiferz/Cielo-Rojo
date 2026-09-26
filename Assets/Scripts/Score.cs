using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    public static float time;
    private float initialTime = 120;
    

    private void Start()
    {
        time = initialTime;
    }

    private void Update()
    {
        

        time -= 1 * Time.deltaTime;
        

        if (score < 0)
        {
            time = 0;
            Time.timeScale = 0;
      
            score = 0;
        }

        if (time < 0)
        {
            Time.timeScale = 0;
            
        }
    }

    public void Reload()
    {
        
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}