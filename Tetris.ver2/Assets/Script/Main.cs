using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

<<<<<<< HEAD
<<<<<<< HEAD
=======
    public BG BGNode;
    public Board BoardNode;
    public Tetromino TetrominoNode;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
    public BG BGNode;
    public Board BoardNode;
    public Tetromino TetrominoNode;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    public GameManager gameManager;
    private float fall = 0;

	// Use this for initialization
	void Start () {
        gameManager.InitGameManager();
    }
<<<<<<< HEAD
<<<<<<< HEAD
	
	// Update is called once per frame
	void Update () {
        gameManager.TetrominoKeyAction();
    }
}
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f

    // Update is called once per frame
    void Update(){
        gameManager.InPutKeyAction();
    }
}   
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
