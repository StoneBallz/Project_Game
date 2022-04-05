using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
   [SerializeField] private int width, height;

   [SerializeField] private Tile _tileprefab;

   [SerializeField] private Transform _cam;

   private Dictionary<Vector2,Tile> game_tiles;

    void Start() {
        Generate_Grid();
    }

    void Generate_Grid(){
        for (int i = 0; i < width; i++){
            for (int j = 0; j < height; j++)
            {
                var spawnedtile = Instantiate(_tileprefab,new Vector3(i,j), Quaternion.identity);
                spawnedtile.name=$"Tile {i} {j}";

                var isoffset=(i+j)%2==1;
                spawnedtile.Init(isoffset);

                game_tiles[new Vector2(i,j)]=spawnedtile;
            }
        }

        _cam.position=new Vector3((float)width/2-0.5f,(float)height/2-1.5f,-10);
    }
}
