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
        lista = transform.GetComponent<Dropdown>();

        lista.ClearOptions();

        User[] us = await ApiHelper.GetUsers();
        List<string> listString = new List<string>();

        foreach (var u in us)
        {
            lista.options.Add(new Dropdown.OptionData() {text = u.name});
        }
    }

}
