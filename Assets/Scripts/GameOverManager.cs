using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    
    [Header("Levels to Load")]
   
    public string newGameLevel;
    private string levelToLoad;


    public void Proceed()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
