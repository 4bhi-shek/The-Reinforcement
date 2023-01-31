using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
public class MenuController : MonoBehaviour
{
   


     

    [Header("Levels to Load")]

    public string newGameLevel;
    private string levelToLoad;
    

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(newGameLevel);
    }

  
       
    
    public void ExitButton()

    {
        Application.Quit();
    }

  
    
}
