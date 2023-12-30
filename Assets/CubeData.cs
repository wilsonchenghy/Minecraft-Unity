using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CubeData
{
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

    public static int[,] orderOfVerticesForDrawingTriangle = new int[6, 6]
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
}
