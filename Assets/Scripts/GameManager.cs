using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Usamos Singleton
    public static GameManager instance;

    public BoardManager boardScript;

    private void Awake(){
        //Iniciamos Singleton
        if(GameManager.instance==null){
            GameManager.instance=this;
        }else if(GameManager.instance != this){
            Destroy(gameObject);
        }

        //Que no se destruya el objecto gameManager al cambiar de escenas
        DontDestroyOnLoad(gameObject);

        boardScript = GetComponent<BoardManager>();
    }

    private void Start(){
        InitGame();
    }

    void InitGame(){
        boardScript.SetupScene(2);
    }
}
