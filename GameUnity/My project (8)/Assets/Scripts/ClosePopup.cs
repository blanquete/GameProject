using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopup : MonoBehaviour
{
    /// <summary>
    /// Obra una petita finestra que mostrarà 
    /// </summary>
    [SerializeField] Button _buttonClose;
    [SerializeField] Text popuptext;
    [SerializeField] GameObject canvas;
    // Update is called once per frame
    void Update()
    {
        //A l'hora de fer click al botó, el canvas es veure setActive(True) Visualment no es veo.
        _buttonClose.onClick.AddListener(() => { canvas.SetActive(false); });
    }
}
