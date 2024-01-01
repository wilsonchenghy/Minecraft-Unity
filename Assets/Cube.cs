//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Cube : MonoBehaviour
//{
//    public MeshFilter meshFilter;
//    public MeshRenderer meshRenderer;

//    int vertexIndex = 0;
//    List<Vector3> vertices = new List<Vector3>();
//    List<int> triangles = new List<int>();
//    List<Vector2> uvMap = new List<Vector2>();



//    void Start()
//    {
//        generatingCubes();
//        createMesh();

//        // print to console
//        Debug.Log("success");
//    }



//    void generatingCubes()
//    {
//        for (int x = 0; x < 5; x++)
//        {
//            for (int y = 0; y < 5; y++)
//            {
//                for (int z = 0; z < 5; z++)
//                {

//                    fillingCubeData(new Vector3(x, y, z));

//                }
//            }
//        }
//    }


//    void fillingCubeData(Vector3 cubePosition)
//    {

//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                int indexForTheCorrespondingVertices = CubeData.orderOfVerticesForDrawingTriangle_ForCube[i, j];
//                vertices.Add(CubeData.cubeVertices[indexForTheCorrespondingVertices] + cubePosition); // in the correct order add the vertices points into the list
//                triangles.Add(vertexIndex);
//                uvMap.Add(Vector2.zero);

//                vertexIndex += 1; //total add 36 times for the 36 vertices generated
//            }
//        }
//    }


//    void createMesh()
//    {
//        Mesh mesh = new Mesh();
//        mesh.vertices = vertices.ToArray();
//        mesh.triangles = triangles.ToArray();
//        mesh.uv = uvMap.ToArray();

//        mesh.RecalculateNormals();

//        meshFilter.mesh = mesh;
//    }
//}