using MongoDB.Bson;
using System;

[Serializable]
public class Dice
{
    public ObjectId O_Id;
    public int id;
    public int sides;
    public int count;
    public int mod;
    public Dice()
    {
        sides = 6;
        count = 1;
        mod = 0;
    }

    public Dice(int sides_)
    {
        sides = sides_;
        count = 1;
        mod = 0;
    }

    public Dice(int sides_, int count_)
    {
        sides = sides_;
        count = count_;
        mod = 0;
    }

    public Dice(int sides_, int count_, int mod_)
    {
        sides = sides_;
        count = count_;
        mod = mod_;
    }

}