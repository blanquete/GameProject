using MongoDB.Bson.IO;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

/// <summary>
/// Classe ApiHelper, classe que serveix per conectarnos a l'API i poder fer GET, POST, UPDATE.
/// </summary>
public class ApiHelper
{
    public TextMeshProUGUI txt;
    public static string dataBase = "http://campalans-rblanco.somee.com/game/api/";
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


    /// <summary>
    /// Funció per poder cercar totes les classes.
    /// </summary>
    /// <returns> Return array de totes les clases.</returns>
    /*public static async Task<TypeClass []> GetTypeClass()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "classes");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
      
        string json = await reader.ReadLineAsync();
        Debug.Log(json);
        TypeClass[] u = JsonHelperOptions.FromJson<TypeClass>(json);
        return u;
    }*/

    /// <summary>
    /// Funcio per poder comprobar si l'usuari existeix.
    /// </summary>
    /// <param name="nickname"></param>
    /// <returns></returns>
    public static async Task<User> GetUser(string nickname)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/nickname/" + nickname);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = await reader.ReadLineAsync();
        return JsonUtility.FromJson<User>(json);
    }

    /// <summary>
    /// Post crear usuari.
    /// </summary>
    /// <param name="json">string json.</param>
    /// <returns></returns>
    public  IEnumerator postUser(string json)
    {
        var uwr = new UnityWebRequest(dataBase + "user", "POST");
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
    
    /// <summary>
    /// Obtenir partida a traves d'una id (Codi).
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Crear partida
    /// </summary>
    /// <param name="json">string json</param>
    /// <returns></returns>
    public IEnumerator postPartida(string json)
    {
        var uwr = new UnityWebRequest(dataBase + "partida", "POST");
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
