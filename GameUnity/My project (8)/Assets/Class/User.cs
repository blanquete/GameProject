using MongoDB.Bson;
using System;
using System.Collections.Generic;

[Serializable]
public class User
{
    public ObjectId o_Id;
    public int id;
    public string name;
    public string last_name;
    public string password;

}/*

[Serializable]
public class UserList
{
    public List<User> users;
}*/

