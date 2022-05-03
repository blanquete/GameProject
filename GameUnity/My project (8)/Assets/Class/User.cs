using MongoDB.Bson;
using System;
using System.IO;

[System.Serializable]
public class User
{
    public ObjectId o_Id { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string last_name { get; set; }
    public string password { get; set; }

    public static implicit operator User(Stream v)
    {
        throw new NotImplementedException();
    }
}

