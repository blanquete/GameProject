using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopup : MonoBehaviour
{
    [SerializeField] Button _buttonClose;
    [SerializeField] Text popuptext;
    [SerializeField] GameObject canvas;
    // Update is called once per frame
    void Update()
    {
        _buttonClose.onClick.AddListener(() => { canvas.SetActive(false); });
    }
}
