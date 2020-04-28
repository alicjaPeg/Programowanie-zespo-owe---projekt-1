using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManu : MonoBehaviour
{
    public Text scoreText;


    private void Start()
    { 
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
    }

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Game has ended its life. Rest in Pepperoni");
        Application.Quit();
    }
}
