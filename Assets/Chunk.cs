using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public MeshFilter meshFilter;
    public MeshRenderer meshRenderer;

    int vertexIndex = 0;
    List<Vector3> vertices = new List<Vector3>();
    List<int> triangles = new List<int>();
    List<Vector2> uvMap = new List<Vector2>();



    void Start()
    {
        generatingCubes();
        createMesh();

        // print to console
        Debug.Log("success");
    }



    void generatingCubes()
    {
        for (int y = 0; y < CubeData.chunkHeight; y++) // green arrow axis
        {
            for (int x = 0; x < CubeData.chunkLength; x++) // red arrow axis
            {
                for (int z = 0; z < CubeData.chunkWidth; z++) // blue arrow axis
                {
                    fillingCubeData(new Vector3(x, y, z));

                }
            }
        }
    }


    bool checkFaceToBeRendered(Vector3 checkingPosition)
    {
        int x = Mathf.FloorToInt(checkingPosition.x);
        int y = Mathf.FloorToInt(checkingPosition.y);
        int z = Mathf.FloorToInt(checkingPosition.z);
        if (x<0 || y<0 || z<0 || (x+1) > CubeData.chunkLength || (y+1) > CubeData.chunkHeight || (z+1) > CubeData.chunkWidth)
        {
            return true;
        }

        return false;
    }


    void fillingCubeData(Vector3 cubePosition)
    {

        for (int i = 0; i < 6; i++)
        {
            if (checkFaceToBeRendered(cubePosition + CubeData.faceChecks[i]))
            {
                for (int j = 0; j < 6; j++)
                    {
                        int indexForTheCorrespondingVertices = CubeData.orderOfVerticesForDrawingTriangle[i, j];
                        vertices.Add(CubeData.cubeVertices[indexForTheCorrespondingVertices] + cubePosition); // in the correct order add the vertices points into the list
                        triangles.Add(vertexIndex);
                        uvMap.Add(Vector2.zero);

                        vertexIndex += 1; //total add 12 times for the 12 vertices generated
                    }
            }   
        }
    }


    void createMesh()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();
        mesh.uv = uvMap.ToArray();

        mesh.RecalculateNormals();

        meshFilter.mesh = mesh;
    }
}