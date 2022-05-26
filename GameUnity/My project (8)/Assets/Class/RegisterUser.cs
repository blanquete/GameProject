using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    public Text t;
    public InputField txtNickname;
    public InputField txtUsuario;
    public InputField txtLastName;
    public InputField txtPassword;

    public Button btn;
    public ApiHelper helper;
    void  Start()
    {
        helper = new ApiHelper(this); 
        system = EventSystem.current;
        firstInput.Select(); //Selecciona el primer item i fa un focus.
    }

    //FUNCIÓN ASOCIADA AL BOTON REGISTER PARA PODER DAR DE ALTA UN USUARIO.
    public void createUser()
    {
        t.text = "";

        if ((txtNickname.text != null && txtUsuario.text != null && txtLastName.text != null && txtPassword.text != null) && (txtNickname.text != "" && txtUsuario.text != "" && txtLastName.text != "" && txtPassword.text != ""))
        {
            User s = new User();
            s.nickname = txtNickname.text;
            s.name = txtUsuario.text;
            s.last_name = txtLastName.text;
            s.password = txtPassword.text;

            string json = JsonUtility.ToJson(s);
            StartCoroutine(helper.postUser(json));
        }
        else 
        {
            t.text = "Has d'omplir tots els camps.";
        }
    }
    public void AvisMissatge(bool x)
    {
        if (x)
        {
            t.text = "L'Usuari s'ha registrat correctament.";
            SceneManager.LoadScene("SceneManager");
        }
        else
        {
            t.text = "Nickname ja existeix.";
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
