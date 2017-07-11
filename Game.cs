﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public int gridwidth = 10;
    public int griheight = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public bool CheckIsInsideGrid(Vector2 pos)
    {
    return ((int) pos.x >=0 && (int)pos.x < gridwidth && (int)pos.y >= 0);

    }
    public Vector2 round(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }
}
