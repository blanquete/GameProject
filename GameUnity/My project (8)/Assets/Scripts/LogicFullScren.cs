using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Clase per poder cambiar la resolució de la finestra i indicar si la finestra la volem Finestra Completa o no.
/// </summary>
public class LogicFullScren : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown tMP_Dropdown;
    Resolution[] resolutions;
    
    void Start()
    {
        //Indique si la finestra esta fullScreen o no.
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }

        revisarResolucion();
    }

    public void activateFullScreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

    public void revisarResolucion()
    {
        tMP_Dropdown.ClearOptions();
        resolutions = Screen.resolutions;
        tMP_Dropdown.ClearOptions();
        List<string> listaux = new List<string>();
        int resolucionActual = 0;
        
        for(int i = 0; i < resolutions.Length; i++)
        {
            //Calculamos la anchura x por la altura.
            string aux = resolutions[i].width + " x " + resolutions[i].height;
            listaux.Add(aux);
            if(Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i;
            }
        }
        tMP_Dropdown.AddOptions(listaux);
        tMP_Dropdown.value = resolucionActual;
        tMP_Dropdown.RefreshShownValue();
        tMP_Dropdown.value = PlayerPrefs.GetInt("numeroResolucion", 0);

    }
    public void cambiarResolucion(int indiceResolucion)
    {
        PlayerPrefs.SetInt("numeroResolucion", tMP_Dropdown.value);

        Resolution resolution = resolutions[indiceResolucion];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    
}

