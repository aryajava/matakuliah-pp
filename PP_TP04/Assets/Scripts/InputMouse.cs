using UnityEngine;

public class InputMouse : MonoBehaviour
{
    string teks1, teks2, teks3, teks4;
    int jmlScroll;
    float delta;

    void Start()
    {
        jmlScroll = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            teks1 = "Mouse: Klik Kiri";
        }
        else if (Input.GetMouseButton(1))
        {
            teks1 = "Mouse: Klik Kanan";
        }
        teks2 = "Position: " + Input.mousePosition.ToString();
        if (Input.mouseScrollDelta.y > 0)
        {
            delta = Input.mouseScrollDelta.y;
            jmlScroll++;
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            delta = Input.mouseScrollDelta.y;
            jmlScroll--;
        }
        teks3 = "Scroll: " + delta.ToString();
        teks4 = "Jumlah Scroll: " + jmlScroll.ToString();
    }
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 5, 400, 200));
        GUILayout.Label(teks1);
        GUILayout.Label(teks2);
        GUILayout.Label(teks3);
        GUILayout.Label(teks4);
        GUILayout.EndArea();
    }
}
