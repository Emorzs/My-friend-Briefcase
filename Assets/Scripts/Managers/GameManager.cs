using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        ChangeState(GameState.GenerateGrid);
    }

    public void ChangeState(GameState newstate)
    {
        GameState = newstate;
        switch (newstate)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnHeroes:
                UnitsManager.Instance.SpawnHeroes();
                break;
            case GameState.SpawnEnemys:
                break;
            case GameState.HeroesTurn:
                break;
            case GameState.EnemysTurn:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newstate), newstate, null);
        }
    }
}

public enum GameState{
    GenerateGrid = 0,
    SpawnHeroes = 1,
    SpawnEnemys = 2,
    HeroesTurn = 3,
    EnemysTurn = 4,
}