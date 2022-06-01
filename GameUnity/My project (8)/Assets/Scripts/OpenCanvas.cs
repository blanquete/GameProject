using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCanvas : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    /// <summary>
    /// Clase per poder obrir el Popup
    /// </summary>
     public void mostra()
    {
        canvas.SetActive(true);
    }
}
