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
public struct Weapon
{
    public string name;
    public int damage;
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public override string ToString()
    {
        return $"{name} (Damage: {damage})";
    }
}