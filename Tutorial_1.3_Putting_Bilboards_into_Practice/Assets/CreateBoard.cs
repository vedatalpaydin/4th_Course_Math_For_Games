﻿using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CreateBoard : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject housePrefab;
    public GameObject treePrefab;
    public Text score;
    private GameObject[] tiles;
    private long dirtBB;
    private long treeBB;
    private long playerBB;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new GameObject[64];
        for (int r = 0; r < 8; r++)
        for (int c = 0; c < 8; c++)
        {
            int randomTile = Random.Range(0, tilePrefabs.Length);
            Vector3 pos = new Vector3(c, 0, r);
            GameObject tile = Instantiate(tilePrefabs[randomTile], pos, Quaternion.identity);
            tile.name = tile.tag + "_" + r + "_" + c;
            tiles[r * 8 + c] = tile;
            if (tile.tag == "Dirt")
            {
                dirtBB = SetCellState(dirtBB, r, c);
                // PrintBB("Dirt",dirtBB);
            }
        }

        Debug.Log("Dirt cells = " + CellCount(dirtBB));
        InvokeRepeating("PlantTree", 0.1f, 0.1f);
    }

    void PlantTree()
    {
        int rr = Random.Range(0, 8);
        int rc = Random.Range(0, 8);
        if (GetCellState(dirtBB & ~playerBB, rr, rc))
        {
            GameObject tree = Instantiate(treePrefab);
            tree.transform.parent = tiles[rr * 8 + rc].transform;
            tree.transform.localPosition = Vector3.zero;
            treeBB = SetCellState(treeBB, rr, rc);
        }
    }

    void PrintBB(string name, long BB)
    {
        Debug.Log(name + ": " + Convert.ToString(BB, 2).PadLeft(64, '0'));
    }

    long SetCellState(long bitboard, int row, int col)
    {
        long newBit = 1L << (row * 8 + col);
        return (bitboard |= newBit);
    }

    bool GetCellState(long bitboard, int row, int col)
    {
        long mask = 1L << (row * 8 + col);
        return ((bitboard & mask) != 0);
    }

    int CellCount(long bitboard)
    {
        int count = 0;
        long bb = bitboard;
        while (bb != 00)
        {
            bb &= bb - 1;
            count++;
        }

        return count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                int r = (int) hit.collider.gameObject.transform.position.z;
                int c = (int) hit.collider.gameObject.transform.position.x;
                if (GetCellState(dirtBB & ~treeBB, r, c))
                {
                    GameObject house = Instantiate(housePrefab);
                    house.transform.parent = hit.collider.gameObject.transform;
                    house.transform.localPosition = Vector3.zero;
                    playerBB = SetCellState(playerBB, r, c);
                }
            }
        }
    }
}