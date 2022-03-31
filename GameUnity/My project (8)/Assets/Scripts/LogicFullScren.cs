using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicFullScren : MonoBehaviour
{
    public Toggle toggle;

    public TMP_Dropdown tMP_Dropdown;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateFullScreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

    public void revisarResolucion()
    {
        List<string> listaux = new List<string>();
        int resolucionActual = 0;

        resolutions = Screen.resolutions;
        tMP_Dropdown.ClearOptions();

        for(int i = 0; i < resolutions.Length; i++)
        {
            //Calculamos que la anchura x por la altura.
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
