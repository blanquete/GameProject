using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    public TextMeshProUGUI txtAvis;
    public InputField txtNickname;
    public InputField txtUsuario;
    public InputField txtLastName;
    public InputField txtPassword;

    public Button btn;
    
    void  Start()
    {
        system = EventSystem.current;
        firstInput.Select(); //Selecciona el primer item i fa un focus.
    }

    //FUNCIÓN ASOCIADA AL BOTON REGISTER PARA PODER DAR DE ALTA UN USUARIO.
    public void createUser()
    {
        User s = new User();

        s.nickname = txtNickname.text;
        s.name = txtUsuario.text;
        s.last_name = txtLastName.text;
        s.password = txtPassword.text;
        ApiHelper helper = new ApiHelper();
        string json = JsonUtility.ToJson(s);
        StartCoroutine(helper.postRequest(ApiHelper.dataBase + "user", json));
       

    }

    public void AvisMissatge(bool x)
    {
        if (x)
        {
            txtAvis.text = "L'Usuari s'ha registrat correctament.";
        }
        else
        {
            txtAvis.text = "Nickname ja existeix.";
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
