using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int bilanganBulat;
    public float bilanganDesimal;
    public char karakter;
    public string teks;
    public enum vote { Bagus, Lumayan, Ok };
    public vote komentar;
    string keterangan;
    public Vector2 koordinat2D;
    public Vector3 koordinat3D;

    void Start()
    {
        if(komentar == vote.Bagus)
            keterangan = "Bagus Sekali...";
        else
            keterangan = "OK";
    }

    void Update()
    {
        GUILayout.BeginArea(new Rect(15, 10, 200, 300));
        GUILayout.Label("Bil. Bulat: " + bilanganBulat.ToString());
        GUILayout.Label("Desimal: " + bilanganDesimal.ToString());
        GUILayout.Label("Satu Karakter: " + karakter.ToString());
        GUILayout.Label("Tulisan: " + teks.ToString());
        GUILayout.Label("Komentar: " + keterangan.ToString());
        GUILayout.Label("2D: " + koordinat2D.ToString());
        GUILayout.Label("3D: " + koordinat3D.ToString());
        GUILayout.EndArea();
    }
}
