using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ejemplo : MonoBehaviour
{
    [Header("Objeto")]
    public Button drop;
    public GameObject p;
    public int n = 0;

    public void RandomGenerate()
    {
        n = Random.Range(1, 13);
        p.GetComponent<Text>().text = "" + n;
    }

   
}
