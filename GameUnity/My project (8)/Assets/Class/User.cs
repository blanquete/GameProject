using MongoDB.Bson;
using System;
using System.Collections.Generic;

/// <summary>
/// Clase User
/// </summary>
[Serializable]
public class User
{
    public ObjectId o_Id;
    public int id;
    public string nickname;
    public string name;
    public string last_name;
    public string password;
}

