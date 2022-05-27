using MongoDB.Bson;
using System;

[Serializable]
public class TypeClass
{
    public ObjectId o_Id;
    public int id;
    public string nickname;
    public string name;
    public string last_name;
    public string password;
}
