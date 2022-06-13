using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obtenerUser : MonoBehaviour
{
    public GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        f = GameObject.FindGameObjectWithTag("usuario");
        f.GetComponent<Text>().text = PlayerPrefs.GetString("usuario");
    }
}
