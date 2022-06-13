using MongoDB.Bson;
using System;

[Serializable]
public class Race
{
    public ObjectId O_Id;
    public int Id;
    public string name;
    public string description;
    public byte[] image;
}
