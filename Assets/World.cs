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

    //[Header("Texture Values")]
    //public int bottomFaceTexture;
    //public int leftFaceTexture;
    //public int backFaceTexture;
    //public int rightFaceTexture;
    //public int frontFaceTexture;
    //public int topFaceTexture;

    //public int getTextureID(int faceIndex)
    //{
    //    switch (faceIndex)
    //    {

    //        case 0:
    //            return backFaceTexture;
    //        case 1:
    //            return frontFaceTexture;
    //        case 2:
    //            return topFaceTexture;
    //        case 3:
    //            return bottomFaceTexture;
    //        case 4:
    //            return leftFaceTexture;
    //        case 5:
    //            return rightFaceTexture;
    //        default:
    //            Debug.Log("Error in GetTextureID");
    //            return 0;
    //    }
    //}
}