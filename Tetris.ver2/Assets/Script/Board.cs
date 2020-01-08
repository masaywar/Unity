using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Use this for initialization

    public void InitBoard()
    {
        BG go = new BG();

        int width = go.GetWidth();
        int height = go.GetHeight();

        for (int i = 0; i < height; i++)
        {
            GameObject col = new GameObject((height - i - 1).ToString());
            col.transform.position = new Vector3(0, height / 2 - i, 0);
            col.transform.parent = transform;
        }
    }
}
