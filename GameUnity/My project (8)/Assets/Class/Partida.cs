using MongoDB.Bson;
using System;

[Serializable]
public class Partida
{
    public ObjectId o_Id;
    public int id;
    public string name;
    public string last_name;
    public string password;

}