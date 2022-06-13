using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TirarDado : MonoBehaviour
{
    public Text p;
    public async void RandomGenerate()
    {
        int i = 0;
        i = await ApiHelper.GetDice();
        p.text = i.ToString();
    }

}
