using UnityEngine;

public class GandakanBola : MonoBehaviour
{
    public GameObject TempatJatuh, Bola;
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        if (GUILayout.Button("Buat Bola") || Input.GetButtonUp("Jump"))     // Menambahkan input keyboard jump/space
        {
            GameObject temp = (GameObject)GameObject.Instantiate(
                Bola, TempatJatuh.transform.position, TempatJatuh.transform.rotation
            );
            Destroy(temp, 5);
        }
        GUILayout.EndArea();
    }
}
