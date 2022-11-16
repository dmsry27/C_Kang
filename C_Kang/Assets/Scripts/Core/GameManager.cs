using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    Warrior player;

    public Warrior Player => player;

    protected override void Initialize()
    {
        player = FindObjectOfType<Warrior>();
    }
}
