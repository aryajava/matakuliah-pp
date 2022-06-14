using UnityEngine;

public class ScriptKubus : MonoBehaviour
{
    public bool Kubus1, Kubus2, Kubus3, Kubus4;
    public string PilihKubus, PilihTag;
    public GameObject PilihObject;

    void Update()
    {
        if (Kubus1) transform.Rotate(1, 0, 0);
        if (Kubus2) GameObject.Find(PilihKubus).transform.Rotate(0, 1, 0);
        if (Kubus3) GameObject.FindGameObjectWithTag(PilihTag).transform.Rotate(0, 0, 1);
        if (Kubus4 && PilihObject != null) PilihObject.transform.Rotate(1, 1, 1);
    }
}
