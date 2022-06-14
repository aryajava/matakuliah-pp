using UnityEngine;

public class ArrayClass : MonoBehaviour
{

    [System.Serializable]
    public class Kelas
    {
        public int ID;
        public string isi;
    }

    string teks;
    public Kelas[] arrayKelas;
    void Start()
    {
        teks = "";
        for (int c = 0; c < arrayKelas.Length; c++)
        {
            teks = teks + arrayKelas[c].ID.ToString() + ": " + arrayKelas[c].isi + " ";
        }
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 65, 400, 200));
        GUILayout.Label("Array Object: " + teks);
        GUILayout.EndArea();
    }

}
