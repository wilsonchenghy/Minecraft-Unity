using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CubeData
{
    public static int chunkHeight = 3;
    public static int chunkWidth = 3;
    public static int chunkLength = 3;

    public static int numOfBlockInTexture = 4; //num of blocks in a row/column of the texture
    public static float NormalisedBlockSizeInTexture = 1.0f/(float)numOfBlockInTexture;

    public static Vector3[] cubeVertices = new Vector3[8]
    {
        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f),
    };

    public static int[,] orderOfVerticesForDrawingTriangle_ForCube = new int[6, 6]
    {
        // bottom face
        {3, 2, 1, 1, 0, 3},
        // left face
        {3, 0, 4, 4, 7, 3},
        // back face
        {2, 3, 7, 7, 6, 2},
        // right face
        {1, 2, 6, 6, 5, 1},
        // front face
        {0, 1, 5, 5, 4, 0},
        // top face
        {4, 5, 6, 6, 7, 4}
    };

    public static int[,] orderOfVerticesForDrawingTriangle_ForChunk = new int[6, 4]
    {
        // bottom face
        {3, 2, 1, 0},
        // left face
        {3, 0, 4, 7},
        // back face
        {2, 3, 7, 6},
        // right face
        {1, 2, 6, 5},
        // front face
        {0, 1, 5, 4},
        // top face
        {4, 5, 6, 7}
    };

    public static Vector3[] faceChecks = new Vector3[6]
    {
        new Vector3(0.0f, 0.0f, -1.0f),
        new Vector3(-1.0f, 0.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(0.0f, -1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f)
    };

    public static Vector2[] uvCoordinate = new Vector2[4]
    {
        new Vector2 (0.0f, 0.0f),
        new Vector2 (1.0f, 0.0f),
        new Vector2 (1.0f, 1.0f),
        new Vector2 (0.0f, 1.0f)
    };
}
