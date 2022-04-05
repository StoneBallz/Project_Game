using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager g_manager;
    public GameState state;

    public static event System.Action<GameState> OnGameStateChange;
    void Awake(){
        g_manager=this;
    }

    void Update_G_State(GameState new_s){
        state=new_s;
        switch(new_s){
            case GameState.PlayerTurn:
                break;

            case GameState.EnemyTurn:
                break;

            case GameState.Win:
                break;

            case GameState.Loss:
                break;
        }
    }
}

public enum GameState{
    PlayerTurn,
    EnemyTurn,
    Win,
    Loss
}
