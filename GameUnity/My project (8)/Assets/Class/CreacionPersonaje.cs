using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreacionPersonaje : MonoBehaviour
{
    public  Dropdown lista;

    private void Start()
    {
        omplirRaces();
    }
    public async  void omplirRaces()
    {
        //ApiHelper.getRequest(ApiHelper.dataBase+"user");

        TypeClass[] us = await ApiHelper.GetTypeClass();

        foreach (TypeClass u in us)
        {
            lista.options.Add(new Dropdown.OptionData() {text = u.name});
        }
    }

}
