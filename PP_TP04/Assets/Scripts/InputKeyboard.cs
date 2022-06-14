using UnityEngine;

public class InputKeyboard : MonoBehaviour
{
    string teks1, teks2;
    public KeyCode pilihanUser;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            teks1 = "KeyDown: Tombol A";
        }
        if (Input.GetKey(KeyCode.B))
        {
            teks1 = "KeyDown: Tombol B";
        }
        if (Input.GetKeyUp(pilihanUser))
        {
            teks1 = "KeyUp: Tombol pilihan user = " + pilihanUser;
        }
        if (Input.anyKey)
        {
            teks2 = "Ada tombol yang ditekan terus menerus";
        }
        else
        {
            teks2 = "";
        }
        if (Input.GetAxis("Fire1") > 0)
        {
            teks1 = "Input dari GetAxis (Left Ctrl/Mouse)";
        }
    }
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 300, 400, 200));
        GUILayout.Label(teks1);
        GUILayout.Label(teks2);
        GUILayout.EndArea();
    }
}
