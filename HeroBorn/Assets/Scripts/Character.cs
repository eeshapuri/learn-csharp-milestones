using UnityEngine;

public class Character
{
    public string name;
    public int level;

    public Character(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public override string ToString()
    {
        return $"{name} (Level {level})";
    }
}