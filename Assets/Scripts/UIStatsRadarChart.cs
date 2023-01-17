using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatsRadarChart : MonoBehaviour
{
    [SerializeField]
    private Material radarMat;

    private Stats stats;
    private CanvasRenderer radarMesh;

    private void Awake()
    {
        radarMesh = transform.Find("mesh").GetComponent<CanvasRenderer>();
    }

    public void SetStats(Stats stats)
    {
        this.stats = stats;
        UpdateStatVisual();
    }

    private void UpdateStatVisual()
    {
        Mesh mesh = new Mesh();

        Vector3[] verts = new Vector3[3];
        Vector2[] uv = new Vector2[3];
        int[] tris = new int[3];

        verts[0] = Vector3.zero;
        verts[1] = new Vector3(0, 100);
        verts[2] = new Vector3(100, 100);

        tris[0] = 0;
        tris[1] = 1;
        tris[2] = 2;

        mesh.vertices = verts;
        mesh.uv = uv;
        mesh.triangles = tris;

        radarMesh.SetMesh(mesh);
        radarMesh.SetMaterial(radarMat, null);
    }
}
