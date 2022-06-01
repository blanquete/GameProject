using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Clase que carrega una escena indicant el nom de la escena
/// </summary>
public class LoadScene : MonoBehaviour
{
   public void LoadScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
