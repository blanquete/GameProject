using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCanvas : MonoBehaviour
{

    [SerializeField] GameObject canvas;
    

     public void mostra()
    {
        canvas.SetActive(true);
    }
}
