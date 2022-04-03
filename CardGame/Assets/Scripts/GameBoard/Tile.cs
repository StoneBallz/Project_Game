using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color base_col, offset_col;
    [SerializeField] private SpriteRenderer s_renderer;

    public void Init(bool isOffset){
        s_renderer.color=isOffset ? offset_col : base_col;
    }
}
