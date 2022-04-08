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
/*string aux = tMP_Dropdown.options[tMP_Dropdown.value].text;

        string[] list = aux.Split();

        for(int i = 0; i < list.Length; i++)
        {
            Debug.Log(list.ToString());
            switch (i)
            {
                case 0:
                    Screen.SetResolution(1920, 1080, true);
                    break;
                case 1:
                    Screen.SetResolution(1680, 1050, true);
                    break;
                case 2:
                    Screen.SetResolution(1600, 900, true);
                    break;
                case 3:
                    Screen.SetResolution(1440, 900, true);
                    break;
                case 4:
                    Screen.SetResolution(1400, 1050, true);
                    break;
                case 5:
                    Screen.SetResolution(1366, 768, true);
                    break;
                case 6:
                    Screen.SetResolution(1360, 768, true);
                    break;
                case 7:
                    Screen.SetResolution(1280, 1024, true);
                    break;
                case 8:
                    Screen.SetResolution(1280, 600, true);
                    break;
                case 9:
                    Screen.SetResolution(1024, 768, true);
                    break;
            }*/
