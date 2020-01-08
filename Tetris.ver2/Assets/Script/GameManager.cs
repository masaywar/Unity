using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;
=======
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f

public class GameManager : MonoBehaviour {

    public Board BoardNode;
    public BG BGNode;
    public Tetromino TetrominoNode;
<<<<<<< HEAD
<<<<<<< HEAD
    public float fallSpeed = 1;

    private float fall = 0;
    private Queue<int> TetrominoSpawnQueue = new Queue<int>();

    // Use this for initialization

    public void InitGameManager() {
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    public Tetromino NextTetromino;
    public Tetromino HoldTetromino;
    public Tetromino ShadowTetromino;
    public float fallSpeed = -1;
    public int score = 0;
    public Text text;

    private int index = 0;
    private int holdingIndex = -1;
    private bool isHold = false;
    private float fall = 0;
    private Stack<int> TetrominoSpawnQueue = new Stack<int>();
    private bool gameOver = false;
    private int combo = 0;

    // Use this for initialization

    public void InitGameManager() { 
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
        BGNode.InitBG();
        BoardNode.InitBoard();
        InitSpawnQueue();
        SpawnTetromino();
    }

    public void SpawnTetromino() {
<<<<<<< HEAD
<<<<<<< HEAD
        TetrominoNode.transform.position = new Vector2(0, BGNode.GetHeight() / 2 - 1);
        int index = TetrominoSpawnQueue.Dequeue();

        switch (index) {
            case 0:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform;
                break;

            case 1:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform;
                break;

            case 2:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform;
                break;

            case 3:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform;
                break;

            case 4:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform; ;
                break;

            case 5:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform; ;
                break;

            case 6:
                Instantiate(TetrominoNode.Tetrominoes[index], TetrominoNode.transform.position, Quaternion.identity).transform.parent = TetrominoNode.transform; ;
                break;
        }

        if (TetrominoSpawnQueue.Count == 0) {
            InitSpawnQueue();
        }
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
        if (gameOver) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        text.text = "Score :" + score;
        TetrominoNode.transform.position = new Vector2(0, BGNode.GetHeight() / 2 - 1);
        NextTetromino.transform.position = new Vector2(BGNode.GetWidth() , BGNode.GetHeight() - 12);
        HoldTetromino.transform.position = new Vector2(BGNode.GetWidth(), BGNode.GetHeight() - 16);
        ShadowTetromino.transform.position = new Vector2(0, BGNode.GetHeight() * 2);
        index = TetrominoSpawnQueue.Pop();

        foreach (Transform tile in ShadowTetromino.transform) {
            Destroy(tile.gameObject);
        }
        ShadowTetromino.transform.DetachChildren();

        DetermineTetromino(TetrominoNode, index);
        DetermineTetromino(ShadowTetromino, index);

        foreach (Transform tile in ShadowTetromino.transform.GetChild(0))
        {
            SpriteRenderer render = tile.GetComponent<SpriteRenderer>();
            Color color = render.color;
            color.a = 0.25f;
            render.color = color;
        }

        if (TetrominoSpawnQueue.Count == 0) {
            InitSpawnQueue();
        }

        ShowNextTetromino();
        ShowHoldTetromino();
    }

    void DetermineTetromino(Tetromino node, int index) {
        switch (index)
        {
            case 0:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform;
                break;

            case 1:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform;
                break;

            case 2:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform;
                break;

            case 3:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform;
                break;

            case 4:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform; ;
                break;

            case 5:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform; ;
                break;

            case 6:
                Instantiate(node.Tetrominoes[index], node.transform.position, Quaternion.identity).transform.parent = node.transform; ;
                break;
        }
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    }

    void GetScored() {

    }

    bool isGameOver() {
        return false;
    }

    void InitSpawnQueue()
    {
        bool[] CheckDuplicate = new bool[7];
        for (int i = 0; i < 7; i++) CheckDuplicate[i] = false;
        while (TetrominoSpawnQueue.Count != 7)
        {
            int index = Random.Range(0, 7);
            if (CheckDuplicate[index] != false)
            {
                continue;
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD
                TetrominoSpawnQueue.Enqueue(index);
=======
                TetrominoSpawnQueue.Push(index);
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
                TetrominoSpawnQueue.Push(index);
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
                CheckDuplicate[index] = true;
            }
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public void TetrominoKeyAction()
    {
        Vector3 oldPos = TetrominoNode.transform.position;
        Quaternion oldRot = TetrominoNode.transform.rotation;
        bool isRotate = false;
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    public void InPutKeyAction() {
        Vector3 oldPos = TetrominoNode.transform.position;
        Quaternion oldRot = TetrominoNode.transform.rotation;
        bool isRotate = false;
        print(combo);

        while (Move(ShadowTetromino, new Vector3(0, -1, 0), isRotate)) ;
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f

        if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fallSpeed)
        {
            fall = Time.time;
<<<<<<< HEAD
<<<<<<< HEAD
            Move(new Vector3(0, -1, 0), isRotate);
=======
            Move(TetrominoNode, new Vector3(0, -1, 0), isRotate);
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
            Move(TetrominoNode, new Vector3(0, -1, 0), isRotate);
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Move(new Vector3(-1, 0, 0), isRotate);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(new Vector3(1, 0, 0), isRotate);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            while (Move(new Vector3(0, -1, 0), isRotate)) ;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isRotate = true;
            Move(new Vector3(0, 0, 0), isRotate);
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
            if (Move(TetrominoNode, new Vector3(-1, 0, 0), isRotate)) {
                ShadowTetromino.transform.position = TetrominoNode.transform.position;
                //Move(ShadowTetromino, new Vector3(0, TetrominoNode.transform.position.y, 0), isRotate);
                //Move(ShadowTetromino, new Vector3(-1, 0, 0), isRotate);
            }
            while (Move(ShadowTetromino, new Vector3(0, -1, 0), isRotate)) ;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Move(TetrominoNode, new Vector3(1, 0, 0), isRotate)) {
                ShadowTetromino.transform.position = TetrominoNode.transform.position;
                //Move(ShadowTetromino, new Vector3(0, TetrominoNode.transform.position.y, 0), isRotate);
                //Move(ShadowTetromino, new Vector3(1, 0, 0), isRotate);
            }
            while (Move(ShadowTetromino, new Vector3(0, -1, 0), isRotate)) ;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            while (Move(TetrominoNode, new Vector3(0, -1, 0), isRotate)) ;
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            HoldingTetromino(index);
        }
        

        if (Input.GetKeyDown(KeyCode.Z))
        {
            isRotate = true;
            Move(ShadowTetromino, new Vector3(0, TetrominoNode.transform.position.y, 0), false);
            if (Move(TetrominoNode, new Vector3(0, 0, 0), isRotate)) {
                Move(ShadowTetromino, new Vector3(0, 0, 0), isRotate);
            }
            while (Move(ShadowTetromino, new Vector3(0, -1, 0), false)) ;
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
            isRotate = false;
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
    bool Move(Vector3 moveDir, bool isRotate)
    {
        Vector3 oldPos = TetrominoNode.transform.position;
        Quaternion oldRot = TetrominoNode.transform.rotation;
        bool canKeppMove = true; 

        if (!isRotate)
        {
            TetrominoNode.transform.position += moveDir;
        }
        else
        {
            TetrominoNode.transform.Rotate(0, 0, 90);
        }

        if (!CheckCanMove(TetrominoNode.transform))
        {
            TetrominoNode.transform.position = oldPos;
            TetrominoNode.transform.rotation = oldRot;
            canKeppMove = false;
            if ((int)moveDir.y == -1 && (int)moveDir.x == 0 && isRotate == false)
            {
                AttachBoard(TetrominoNode.transform);
                CleanLine();
                TetrominoNode.transform.DetachChildren();
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    bool Move(Tetromino node, Vector3 moveDir, bool isRotate){
        Vector3 oldPos = node.transform.position;
        Quaternion oldRot = node.transform.rotation;
        bool moveFlag = false;

        if (!isRotate)
        {
            node.transform.position += moveDir;
        }
        else
        {
            node.transform.Rotate(0, 0, 90);
        }
        moveFlag = true;

        if (!CheckCanMove(node.transform))
        {
            node.transform.position = oldPos;
            node.transform.rotation = oldRot;
            moveFlag = false;
            if (!CheckCanMove(node.transform)) {
                gameOver = true;
            }

            if ((int)moveDir.y == -1 && (int)moveDir.x == 0 && isRotate == false && node.name == "Tetromino")
            {
                isHold = false;
                AttachBoard(node.transform);
                score += 50;
                node.transform.DetachChildren();
                CheckCleanLine();
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
                SpawnTetromino();
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
        return canKeppMove;
=======
        return moveFlag;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
        return moveFlag;
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
    }

    bool CheckCanMove(Transform node)
    {
        for (int i = 0; i < node.GetChild(0).childCount; i++)
        {
            Transform tile = node.transform.GetChild(0).GetChild(i);
<<<<<<< HEAD
<<<<<<< HEAD
            int x = Mathf.RoundToInt(tile.position.x + Mathf.RoundToInt(BGNode.GetWidth() / 2) - 1);
            int y = Mathf.RoundToInt(tile.position.y + Mathf.RoundToInt(BGNode.GetHeight() / 2));
=======
            int x = Mathf.RoundToInt(tile.position.x + Mathf.RoundToInt(BGNode.GetWidth() * 0.5f) - 1);
            int y = Mathf.RoundToInt(tile.position.y + Mathf.RoundToInt(BGNode.GetHeight() * 0.5f));
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
            int x = Mathf.RoundToInt(tile.position.x + Mathf.RoundToInt(BGNode.GetWidth() * 0.5f) - 1);
            int y = Mathf.RoundToInt(tile.position.y + Mathf.RoundToInt(BGNode.GetHeight() * 0.5f));
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f

            if (x < 0 || x > BGNode.GetWidth() - 1)
            {
                return false;
            }

            if (y < 0)
            {
                return false;
            }

            Transform column = BoardNode.transform.Find(y.ToString());
            if (column != null && column.Find(x.ToString()) != null) return false;
        }
        return true;
    }

    void AttachBoard(Transform node)
    {
        while (node.GetChild(0).childCount != 0)
        {
            Transform child = node.GetChild(0).GetChild(0);

            int x = Mathf.RoundToInt(child.position.x + Mathf.RoundToInt(BGNode.GetWidth() / 2) - 1);
            int y = Mathf.RoundToInt(child.position.y + Mathf.RoundToInt(BGNode.GetHeight() / 2));

            child.parent = BoardNode.transform.Find(y.ToString());
            child.name = x.ToString();
        }
<<<<<<< HEAD
<<<<<<< HEAD
    }

    void CleanLine()
    {
        bool isClear = false;
        int emptyLine = 0;
        foreach (Transform column in BoardNode.transform)
        {
            if (column.childCount == BGNode.GetWidth())
            {
                isClear = true;
                emptyLine++;
            }
        }

        if (isClear) {
            foreach (Transform column in BoardNode.transform)
            {
                if (column.childCount == BGNode.GetWidth())
                {
                    foreach(Transform tile in column) {
                        Destroy(tile.gameObject);
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
        Destroy(node.GetChild(0).gameObject);
    }

    void CheckCleanLine() {
        bool isClean = false;
        int empty = 0;

        foreach (Transform column in BoardNode.transform) {
            if (column.childCount == BGNode.GetWidth()) {
                foreach (Transform tile in column) {
                    Destroy(tile.gameObject);
                    empty++;
                }
                column.DetachChildren();
                isClean = true;
            }
        }

        if (isClean)
        {
            for (int i = 1; i < BoardNode.transform.childCount; i++)
            {
                Transform column = BoardNode.transform.Find(i.ToString());

                if (column.childCount == 0) continue;

                int emptyLine = 0;
                int j = i - 1;
                while (j >= 0)
                {
                    if (BoardNode.transform.Find(j.ToString()).childCount == 0)
                    {
                        emptyLine++;
                    }
                    j--;
                }

                if (emptyLine > 0)
                {
                    Transform targetLine = BoardNode.transform.Find((i - emptyLine).ToString());
                    while (column.childCount > 0)
                    {
                        Transform tile = column.GetChild(0);
                        tile.parent = targetLine;
                        tile.transform.position += new Vector3(0, -emptyLine, 0);
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
                    }
                    column.DetachChildren();
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
            if (empty == 4) score += 400 + (combo + 1) * 50;
            else score += empty * (combo + 1) * 50;

            if (combo < 10)
            {
                combo++;
            }
        }
        else combo = 0;
       
    }

    void ShowNextTetromino() {
        int next = TetrominoSpawnQueue.Peek();
        foreach (Transform tile in NextTetromino.transform) {
            Destroy(tile.gameObject);
        }
        NextTetromino.transform.DetachChildren();
        DetermineTetromino(NextTetromino, next);
        foreach (Transform tile in NextTetromino.transform) {
            tile.localScale -= new Vector3(0.3f, 0.3f, 0);
        }
    }

    void HoldingTetromino(int index) {
        if (holdingIndex == -1)
        {
            int temp = index;
            holdingIndex = temp;
            isHold = true;

            foreach (Transform tile in TetrominoNode.transform)
            {
                Destroy(tile.gameObject);
            }
            SpawnTetromino();
        }
        else if (!isHold) {
            int temp = holdingIndex;
            TetrominoSpawnQueue.Push(temp);
            holdingIndex = index;
            isHold = true;

            foreach (Transform tile in TetrominoNode.transform)
            {
                Destroy(tile.gameObject);
            }
            SpawnTetromino();
        }
        //TetrominoNode.transform.DetachChildren();
        //Destroy(TetrominoNode.transform.gameObject);
    }

    void ShowHoldTetromino() {
        foreach (Transform tile in HoldTetromino.transform) {
            Destroy(tile.gameObject);
        }
        if(holdingIndex >= 0)
            DetermineTetromino(HoldTetromino, holdingIndex);
        foreach (Transform tile in HoldTetromino.transform) {
            tile.localScale -= new Vector3(0.3f, 0.3f, 0);
<<<<<<< HEAD
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
=======
>>>>>>> 2ffb2153962c5a5de318086ad124fed0b7f6fe0f
        }
    }
}
