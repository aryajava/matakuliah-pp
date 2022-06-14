using UnityEngine;

public class MenuSkin : MonoBehaviour
{
    public GUISkin mySkin;
    bool value = true;
    void OnGUI()
    {
        GUI.skin = mySkin;
        value = GUI.Toggle(new Rect(20, 20, 60, 60), value, "");
        if (GUI.Button(new Rect(20, Screen.height - 70, 200, 60), "Mulai")) Debug.Log("Tombol Mulai diklik");
        if (GUI.Button(new Rect(240, Screen.height - 70, 200, 60), "Pilihan")) Debug.Log("Tombol Pilihan diklik");
        if (GUI.Button(new Rect(460, Screen.height - 70, 200, 60), "Keluar")) Debug.Log("Tombol Keluar diklik");
    }
}
