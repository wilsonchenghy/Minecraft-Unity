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
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f),
    };

    public static int[,] orderOfVerticesForDrawingTriangle = new int[6, 6]
    {
        // bottom face
        {0, 1, 2, 2, 3, 0},
        // left face
        {4, 0, 3, 3, 4, 7},
        // back face
        {7, 3, 2, 2, 6, 7},
        // right face
        {5, 1, 2, 2, 6, 5},
        // front face
        {4, 0, 1, 1, 5, 4},
        // top face
        {7, 4, 5, 5, 6, 7}
    };
}
