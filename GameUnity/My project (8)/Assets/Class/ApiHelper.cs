using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class ApiHelper : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public static string dataBase = "http://campalans-rblanco.somee.com/game/api/";

    //Obtener un ÚNICO usuario
    public static async Task<User> GetUser(int id)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/" + id);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        Debug.Log(json);
        Debug.Log(request.Address);
        return JsonUtility.FromJson<User>(json);
    }

    //Obtener usuarios
    public static async Task<User> GetUsers()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        /*string [] aux = json.Split('}');
        string [] aux1 = json.Split(',');
        string [] aux2 = json.Split('{');

        string[] resultado;*/
        Debug.Log(json);
        return JsonUtility.FromJson<User>(json);


        /*[{"o_Id":{"timestamp":1651156587,"machine":796430,"pid":-396,"increment":7924912,"creationTime":"2022-04-28T14:36:27Z"},"id":1,"name":"Raul","last_name":"Blanco","password":"12345"}
         *{"o_Id":{"timestamp":1652277967,"machine":1230717,"pid":2534,"increment":1278575,"creationTime":"2022-05-11T14:06:07Z"},"id":2,"name":"Isaac","last_name":"Prats","password":"12345"}]*/
    }

    //Obtener partida
    public static async Task<Partida> GetPartida(int id)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "partida/" + id);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        Debug.Log(json);
        Debug.Log(request.Address);
        return JsonUtility.FromJson<Partida>(json);
    }

    //Crear Partida
    public static async Task<Partida> PostPartida(int id)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "partida/" + id);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        Debug.Log(json);
        Debug.Log(request.Address);
        return JsonUtility.FromJson<Partida>(json);
    }

}
