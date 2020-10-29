﻿using System;

/// <summary>heath modifier</summary>
public enum Modifier
{
	/// <summary>weak modifier</summary>
	Weak = 1,
	/// <summary>Base Value</summary>
	Base = 2,
	/// <summary>Strong modifier</summary>
	Strong = 3
}
/// <summary> delegate to health calculator</summary>
delegate void CalculateHealth(float health);
/// <summary> delegate to calculate modifiers</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary>Hp Args class</summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
	private string status;
	EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>Constructor for Player class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
		this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    ///<summary>Prints Player health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
	 ///<summary>Calculates Player damage.</summary>
    public void TakeDamage(float damage)
    {
		if (damage < 0f)
            damage = 0f;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        float newHp = this.hp - damage;
		this.ValidateHP(newHp);
    }

    ///<summary>Calculates Player healing.</summary>
    public void HealDamage(float heal)
    {
		if (heal < 0f)
            heal = 0f;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        float newHp = this.hp + heal;
		this.ValidateHP(newHp);
    }
	/// <summary> Validates HP within scale</summary>
	public void ValidateHP(float newHP)
	{
		if (newHP < 0)
			this.hp = 0;
		else if (newHP > this.maxHp)
		{
			this.hp = this.maxHp;
		}
		else
			{
				this.hp = newHP;
				HPCheck(this, new CurrentHPArgs(this.hp));
			}
	}
	/// <summary>Applies modifier to health</summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return (baseValue * ((float)modifier / 2f));
    }
	private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }
}