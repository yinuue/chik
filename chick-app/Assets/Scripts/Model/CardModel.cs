using System.Collections;
using System.Collections.Generic;
using Def;
using UnityEngine;

public class CardModel
{
    public delegate void Effect();

    // ================================================
    // parameter
    // ================================================
    public int ID;
    public AppDef.CardType CardType;
    public Effect CardEffect;

    // ================================================
    // method
    // ================================================
    public CardModel(int id, AppDef.CardType type, Effect effect)
    {
        ID = id;
        CardType = type;
        CardEffect = effect;
    }
}