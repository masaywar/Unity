using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {

    public GameObject tile;
    public int BoardWidth = 10;
    public int BoardHeight = 20;
    // Use this for initialization

    public void InitBG () {
        tile.transform.position = new Vector2(BoardWidth/2, BoardHeight/2);
        CreateBackGround();
	}
	
	// Update is called once per frame

    void CreateBackGround() {
        for (int i = BoardHeight / 2; i > -BoardHeight / 2 - 1; i--) {
            CreateGrid(new Vector2(BoardWidth / 2 + 1, i));
            CreateGrid(new Vector2(-BoardWidth / 2, i));
        }

        for (int i = -BoardWidth / 2; i < BoardWidth / 2 + 2; i++) {
            CreateGrid(new Vector2(i, -BoardHeight / 2 - 1));
        }
    }

    void CreateGrid(Vector2 pos) {
        var go = Instantiate(tile);
        go.transform.position = pos;
        go.transform.parent = transform;
    }

    public int GetWidth() {
        return BoardWidth;
    }

    public int GetHeight() {
        return BoardHeight;
    }
}
