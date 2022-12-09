using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{

    Start, Pause, Win1, Win2, Win3, Win4, InGame
}

public class GameManager : MonoBehaviour{

    public GameState currentGameState = GameState.Start;
    public static GameManager sharedInstance;

    [Header("Canvas")]
    [SerializeField] GameObject canvasStart;
    [SerializeField] GameObject canvasUI;
    [SerializeField] GameObject canvasWinner1;
    [SerializeField] GameObject canvasWinner2;
    [SerializeField] GameObject canvasWinner3;
    [SerializeField] GameObject canvasWinner4;
    
    [Header("Player 1")]
    [SerializeField] GameObject spawnPoint1;
    [SerializeField] GameObject playerCamera1;
    [SerializeField] GameObject thePlayer1;

    [Header("Player 2")]
    [SerializeField] GameObject spawnPoint2;
    [SerializeField] GameObject playerCamera2;
    [SerializeField] GameObject thePlayer2;

    [Header("Player 3")]
    [SerializeField] GameObject spawnPoint3;
    [SerializeField] GameObject playerCamera3;
    [SerializeField] GameObject thePlayer3;

    [Header("Player 4")]
    [SerializeField] GameObject spawnPoint4;
    [SerializeField] GameObject playerCamera4;
    [SerializeField] GameObject thePlayer4;

    private void Awake(){

        if (sharedInstance == null) {

            sharedInstance = this;
        }

    }

    void Start(){ }

    void Update(){

        if (Input.GetKeyDown(KeyCode.K)){

            StartGame();
        }
    }

    public void StartGame(){

        SetGameState(GameState.InGame);
    }

    public void PauseGame(){

        SetGameState(GameState.Pause);
    }

    public void Win1Game() {

        SetGameState(GameState.Win1);
    }

    public void Win2Game(){

        SetGameState(GameState.Win2);
    }

    public void StartState(){

        SetGameState(GameState.Start);
    }

    private void SetGameState(GameState newGameState) {

        if (newGameState == GameState.Pause) {

        } else if (newGameState == GameState.InGame) {

            canvasUI.SetActive(true);
            canvasStart.SetActive(false);

            canvasWinner1.SetActive(false);
            canvasWinner2.SetActive(false);
            canvasWinner3.SetActive(false);
            canvasWinner4.SetActive(false);

            thePlayer1.SetActive(true);
            thePlayer2.SetActive(true);
            thePlayer3.SetActive(true);
            thePlayer4.SetActive(true);

            ShowPlayerOnScreen();

        } else if (newGameState == GameState.Win1) {

            canvasUI.SetActive(false);
            canvasStart.SetActive(false);

            canvasWinner1.SetActive(true);
            canvasWinner2.SetActive(false);
            canvasWinner3.SetActive(false);
            canvasWinner4.SetActive(false);

            thePlayer1.SetActive(false);
            thePlayer2.SetActive(false);
            thePlayer3.SetActive(false);
            thePlayer4.SetActive(false);

        } else if (newGameState == GameState.Win2) {

            canvasUI.SetActive(false);
            canvasStart.SetActive(false);

            canvasWinner1.SetActive(false);
            canvasWinner2.SetActive(true);
            canvasWinner3.SetActive(false);
            canvasWinner4.SetActive(false);

            thePlayer1.SetActive(false);
            thePlayer2.SetActive(false);
            thePlayer3.SetActive(false);
            thePlayer4.SetActive(false);

        } else if (newGameState == GameState.Win3){

            canvasUI.SetActive(false);
            canvasStart.SetActive(false);

            canvasWinner1.SetActive(false);
            canvasWinner2.SetActive(false);
            canvasWinner3.SetActive(true);
            canvasWinner4.SetActive(false);

            thePlayer1.SetActive(false);
            thePlayer2.SetActive(false);
            thePlayer3.SetActive(false);
            thePlayer4.SetActive(false);

        } else if (newGameState == GameState.Win4){

            canvasUI.SetActive(false);
            canvasStart.SetActive(false);

            canvasWinner1.SetActive(false);
            canvasWinner2.SetActive(false);
            canvasWinner3.SetActive(false);
            canvasWinner4.SetActive(true);

            thePlayer1.SetActive(false);
            thePlayer2.SetActive(false);
            thePlayer3.SetActive(false);
            thePlayer4.SetActive(false);

        }
        else if (newGameState == GameState.Start) {

            canvasUI.SetActive(false);
            canvasStart.SetActive(true);

            canvasWinner1.SetActive(false);
            canvasWinner2.SetActive(false);
            canvasWinner3.SetActive(false);
            canvasWinner4.SetActive(false);

            thePlayer1.SetActive(false);
            thePlayer2.SetActive(false);
            thePlayer3.SetActive(false);
            thePlayer4.SetActive(false);
        }

        this.currentGameState = newGameState;
    }

    public void ShowPlayerOnScreen(){

        thePlayer1.transform.position = spawnPoint1.transform.position;
        playerCamera1.transform.position = new Vector3(spawnPoint1.transform.position.x,
            spawnPoint1.transform.position.y, playerCamera1.transform.position.z);

        thePlayer2.transform.position = spawnPoint2.transform.position;
        playerCamera2.transform.position = new Vector3(spawnPoint2.transform.position.x,
            spawnPoint2.transform.position.y, playerCamera2.transform.position.z);

        thePlayer3.transform.position = spawnPoint3.transform.position;
        playerCamera3.transform.position = new Vector3(spawnPoint3.transform.position.x,
            spawnPoint3.transform.position.y, playerCamera3.transform.position.z);

        thePlayer4.transform.position = spawnPoint4.transform.position;
        playerCamera4.transform.position = new Vector3(spawnPoint4.transform.position.x,
            spawnPoint4.transform.position.y, playerCamera4.transform.position.z);
    }
}