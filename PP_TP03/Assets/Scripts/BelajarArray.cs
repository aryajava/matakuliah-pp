using UnityEngine;

public class BelajarArray : MonoBehaviour
{
    public int[] arrayAngka;
    public string[] arrayTeks;
    string teks1, teks2, teks3;

    void Start()
    {
        teks1 = "";
        for (int a = 0; a < arrayAngka.Length; a++)
        {
            teks1 = teks1 + arrayAngka[a].ToString() + " ";
        }
        teks2 = "";
        for (int a = 0; a < arrayTeks.Length; a++)
        {
            teks2 = teks2 + arrayTeks[a].ToString() + " ";
        }
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 15, 400, 200));
        GUILayout.Label("Array Integer: " + teks1);
        GUILayout.Label("Array String: " + teks2);
        GUILayout.EndArea();
    }

}
