using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
[Serializable]

public class ApiHelper : MonoBehaviour
{
    [Header("Objeto")]
   
    public TextMeshProUGUI dropTxt;

    public static string dataBase = "http://campalans-rblanco.somee.com/game/api/";

    public static List<User> GetAll()
    {

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<List<User>>(json);

    }
    public async Task<User> GetUser(int id)
    {
        /*string json = "";
        var result = await Task.Run(async () =>
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataBase + "user/" + id);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            json = await reader.ReadToEndAsync();
            Debug.Log(json);
            return JsonUtility.FromJson<User>(json);
        });
        JsonUtility.FromJsonOverwrite(json, dropTxt);
        return JsonUtility.FromJson<User>(json);*/


        User user = new User();
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(dataBase);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Enviem una petició GET al endpoint /users/{Id}
            HttpResponseMessage response2 = await client.GetAsync($"user/{id}");
            if (response2.IsSuccessStatusCode)
            {
                //Reposta 204 quan no ha trobat dades
                if (response2.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    user = null;
                }
                else
                {
                    //Obtenim el resultat i el carreguem al Objecte User
                    user = await Task.Run(async () => await response2.Content.ReadAsHttpRequestMessageAsync<User>());
                    response2.Dispose();
                }
            }
            else
            {
                //TODO: que fer si ha anat malament? retornar null? 
            }
           
           
            return user;
        }

    }

    private async void Start()
    {
        User usuari = await GetUser(7);
        Debug.Log(usuari.id);
        Debug.Log(usuari.name);

        dropTxt.text = usuari.name;
    }
}
