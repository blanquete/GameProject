using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    public Text text;
    public InputField txtUsuario;
    
    async void Start()
    {
        system = EventSystem.current;
        firstInput.Select(); //Selecciona el primer item i fa un focus.

        User listUser = await ApiHelper.GetUsers();
        Debug.Log("entrar");

        foreach (var item in listUser.)
        {
            if (txtUsuario.text == item.name)
            {
                text.text = "El usuario ya existe";
            }
            else
            {
                Debug.Log("Hola k ase");
            }
        }
    }

    //Funció per poder tabular. 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if(next != null)
            {
                next.Select();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (next != null)
            {
                next.Select();
            }
        }
    }

}
