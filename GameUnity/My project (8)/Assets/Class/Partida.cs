using MongoDB.Bson;
using System;

[Serializable]
public class Partida
{
    public ObjectId O_Id;
    public int Id;
    public string code;
    public string name;
    public string description;
    public int[] characters_id;
    public int[] users_id;
    public int game_master_id;
    public bool online;
    public bool in_game;
    public int last_scene_id;
    public int user_current_id;
}