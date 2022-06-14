using UnityEngine;

public class ManipulasiKamera : MonoBehaviour
{
    public Camera KamUtama, Kam1, Kam2, Kam3;

    void StatusKamera(bool status)
    {
        KamUtama.GetComponent<Camera>().enabled = status;
        Kam1.GetComponent<Camera>().enabled = status;
        Kam2.GetComponent<Camera>().enabled = status;
        Kam3.GetComponent<Camera>().enabled = status;
    }

    void KameeraSplit()
    {
        StatusKamera(true);
        KamUtama.GetComponent<Camera>().rect = new Rect(0f, 0, 0.5f, 0.5f);
        Kam1.GetComponent<Camera>().rect = new Rect(0.5f, 0, 1f, 0.5f);
        Kam2.GetComponent<Camera>().rect = new Rect(0, 0.5f, 0.5f, 1f);
        Kam3.GetComponent<Camera>().rect = new Rect(0.5f, 0.5f, 1f, 1f);
    }

    void Start()
    {
        StatusKamera(false);
        KamUtama.GetComponent<Camera>().enabled = true;
    }

    void Update()
    {
        if (Input.GetKey("k"))
        {
            StatusKamera(false);
            KamUtama.GetComponent<Camera>().enabled = true;
            KamUtama.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 1f);
        }
        if (Input.GetKey("1"))
        {
            StatusKamera(false);
            Kam1.GetComponent<Camera>().enabled = true;
            Kam1.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 1f);
        }
        if (Input.GetKey("2"))
        {
            StatusKamera(false);
            Kam2.GetComponent<Camera>().enabled = true;
            Kam2.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 1f);
        }
        if (Input.GetKey("3"))
        {
            StatusKamera(false);
            Kam3.GetComponent<Camera>().enabled = true;
            Kam3.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 1f);
        }
        if (Input.GetKey("s")){
            KameeraSplit();
        } 
    }
}
