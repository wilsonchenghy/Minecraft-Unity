using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public Material material;
    public Blocktype[] blocktypes;
}



[System.Serializable]
public class Blocktype
{
    public string blockName;
    public bool isSolid;
}