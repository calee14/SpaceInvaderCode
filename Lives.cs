using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public Text livesText;
    private int lives = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Health: " + lives + "%"; 
    }

    public void LoseLives()
    {
        if (lives > 0)
        {
            lives = lives -25;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void LoseLotsLives()
    {
        if (lives > 0)
        {
            lives = lives - 50;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
