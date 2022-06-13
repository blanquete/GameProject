using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createPersonaje : MonoBehaviour
{
    public Dropdown lista;
    public Dropdown lista2;
    
   
    private void Start()
    {
        omplirRaces();
        omplirTypleClass();
    }

    public void guardarPersonaje()
    {
        int id_race = lista.value + 1;
        int id_class = lista2.value + 1;
    }

    public async void omplirRaces()
    {
        ApiHelper.GetRace();

        Race[] us = await ApiHelper.GetRace();

        foreach (Race u in us)
        {
            lista.options.Add(new Dropdown.OptionData() { text = u.name });
        }
    }

    public async void omplirTypleClass()
    {
        ApiHelper.GetTypeClass();
        TypeClass[] us = await ApiHelper.GetTypeClass();

        foreach (TypeClass u in us)
        {
            lista2.options.Add(new Dropdown.OptionData() { text = u.name });
        }
        
    }
}



