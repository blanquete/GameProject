using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class ApiHelper : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public static string dataBase = "http://campalans-rblanco.somee.com/game/api/";

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

    public static async Task<Partida> GetPartida(int id)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/" + id);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        Debug.Log(json);
        Debug.Log(request.Address);
        return JsonUtility.FromJson<Partida>(json);
    }



}
