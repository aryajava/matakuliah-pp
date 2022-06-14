using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject text3d;
    public string pesan;
    int score;

    void Start()
    {
        Sembunyikan();
        text3d.GetComponent<TextMesh>().text = pesan;
        score = 0;
    }

    void Sembunyikan()
    {
        text3d.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Peluru")
        {
            Destroy(other.gameObject);
            score++;
            text3d.GetComponent<MeshRenderer>().enabled = true;
            Invoke("Sembunyikan", 1);
        }
    }
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 400, 200));
        GUILayout.Label("Score  :   " + score.ToString());
        GUILayout.EndArea();
    }
}
