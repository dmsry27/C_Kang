using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    Player player;

    public Player Player => player;

    protected override void Initialize()
    {
        player = FindObjectOfType<Player>();
    }
}
