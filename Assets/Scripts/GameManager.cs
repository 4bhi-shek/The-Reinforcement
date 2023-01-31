using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Gameover");
            Restart();
        }
       
    }
    void Restart()
    {
        
        SceneManager.LoadScene("GameOver");
        Cursor.lockState = CursorLockMode.None;
    }
}


