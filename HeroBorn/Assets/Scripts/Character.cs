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
public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name, int level, Weapon weapon) : base(name, level)
    {
        this.weapon = weapon;
    }

    public string PrintStatsInfo()
    {
        return $"{name} (Level {level}) wields a {weapon.name} that deals {weapon.damage} damage.";
    }
}