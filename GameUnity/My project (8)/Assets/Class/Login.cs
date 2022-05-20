using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    EventSystem system; 
    public Selectable firstInput;
    public Text t;
    public InputField txtNickname;
    public InputField txtPassword;
    void Start()
    {
        system = EventSystem.current;
        firstInput.Select(); //Selecciona el primer item i fa un focus.
    }


    public async void comprobar()
    {
        if(txtNickname.text != "" && txtPassword.text != "")
        {
            User u = await ApiHelper.GetUser(txtNickname.text);
            try
            {
                if (u.nickname != null)
                {
                    if (u.password == txtPassword.text)
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                    else
                    {
                        t.text = "Contrasenya incorrecte";
                    }
                }
            }
            catch (System.Exception e)
            {
                t.text = "Usuari incorrecte";
                Debug.Log(t.text);
            }
        }
        else
        {
            t.text = "Has d'en emplenar tots els camps.";
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (next != null)
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
