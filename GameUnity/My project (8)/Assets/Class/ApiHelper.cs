using MongoDB.Bson.IO;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class ApiHelper
{
    public TextMeshProUGUI txt;
    public static string dataBase = "http://campalans-rblanco.somee.com/game/api/";
    //public static RegisterUser ru = new RegisterUser();
    public RegisterUser ru;
    public ApiHelper(RegisterUser ruSended)
    {
        ru = ruSended;
    }

    public static IEnumerator IAsyncEnumerator(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return  uwr.SendWebRequest();
        ;
        if (uwr.result ==  UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }

    public static async Task<User []> GetUsers()
    {
       
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
      
        string json = await reader.ReadLineAsync();
        User[] u = JsonHelper.FromJson<User>(json);

        return u;

    }

    //COMPROBAR SI L'USUARI EXISTEIX
    public static async Task<User> GetUser(string nickname)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/nickname/" + nickname);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        return JsonUtility.FromJson<User>(json);
    }

    //POST CREAR USUARIO Y DAR REGISTRO EN MONGO.
    public  IEnumerator postRequest(string url, string json)
    {
        
        var uwr = new UnityWebRequest(url, "POST");
        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
        uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
        uwr.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");

        //Send the request then wait here until it returns
        yield return uwr.SendWebRequest();

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);

            if (uwr.downloadHandler.text == "false")
            {
                Debug.Log("Entra false");
                ru.AvisMissatge(false);


            }
            else
            {
                Debug.Log("Entra true");
                ru.AvisMissatge(true);
            }
        }
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

//Obtener usuarios
/*public static async Task<UserList<User>> GetUsers()
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user");
    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    StreamReader reader = new StreamReader(response.GetResponseStream());
    string json = await reader.ReadLineAsync();

    return JsonUtility.FromJson<UserList<User>>(json);
}*/

/*public static IEnumerator GetUsers()
{
    using (UnityWebRequest request = UnityWebRequest.Get(dataBase + "user"))
    {
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
            string json = request.downloadHandler.text;
            User [] users = JsonUtility.FromJson(json, User []);

            Debug.Log(users);
        }

    }
}*/



//Obtener un ÚNICO usuario
/*public static async Task<User> GetUser(int id)
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/" + id);
    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    StreamReader reader = new StreamReader(response.GetResponseStream());
    string json = await reader.ReadLineAsync();
    Debug.Log(json);
    Debug.Log(request.Address);
    return JsonUtility.FromJson<User>(json);
}*/
