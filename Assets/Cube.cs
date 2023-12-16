using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshFilter meshFilter;
    public MeshRenderer meshRenderer;

    List<Vector3> vertices = new List<Vector3>();
    List<int> triangles = new List<int>();
    List<Vector2> uvMap = new List<Vector2>();


    void Start()
    {
        fillArraysWithData();
        createMesh();

        // print to console
        Debug.Log("success");
    }


    void fillArraysWithData()
    {
        int vertexIndex = 0;

        for (int i=0; i<6; i++)
        {
            for (int j=0; j<6; j++)
            {
                int indexForTheCorrespondingVertices = CubeData.orderOfVerticesForDrawingTriangle[i,j];
                vertices.Add(CubeData.cubeVertices[indexForTheCorrespondingVertices]); // in the correct order add the vertices points into the list
                triangles.Add(vertexIndex);
                uvMap.Add(Vector2.zero);

                vertexIndex += 1; //total add 12 times for the 12 vertices generated
            }
        }

        Debug.Log("Assigned");
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