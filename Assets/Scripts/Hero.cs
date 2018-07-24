using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Hero
{
    public int id;
    public float currentHp;
    public float maxHp;
    public float attack;
    public float defence;
    public string name;

    public Hero()
    {

    }

    public Hero(int id, float maxHp, float attack, float defence)
    {
        this.id = id;
        this.maxHp = maxHp;
        this.currentHp = this.maxHp;
        this.attack = attack;
        this.defence = defence;
    }

    public float PowerRank
    {
        get
        {
            return 0.5f * maxHp + 0.2f * attack + 0.3f * defence;
        }
    }

    public bool IsHero
    {
        get
        {
            return true;
        }
    }
}
