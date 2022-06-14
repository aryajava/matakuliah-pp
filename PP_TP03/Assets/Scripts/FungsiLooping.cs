using UnityEngine;

public class FungsiLooping : MonoBehaviour
{
    int no1, no2, no3, no4, no5, hitungMundur;
    void Start()
    {
        no1 = 0; no2 = 0; no3 = 0; no4 = 0; no5 = 0;
        hitungMundur = 3;
        InvokeRepeating("HitungMundur", 1, 1);
    }

    void Update()
    {
        if (hitungMundur == 0) no1++;
    }
    void FixedUpdate()
    {
        if (hitungMundur == 0) no2++;
    }
    void Looping1()
    {
        no3++;
    }
    void Looping2()
    {
        no4++;
    }
    void NoLooping()
    {
        no5++;
    }
    void HitungMundur()
    {
        hitungMundur--;
        if (hitungMundur == 0)
        {
            InvokeRepeating("Looping1", 1, 1);
            InvokeRepeating("Looping2", 5, 0.5f);
            Invoke("NoLooping", 10);
            CancelInvoke("HitungMundur");
        }
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 115, 400, 200));
        if (hitungMundur == 0)
        {
            GUILayout.Label("Update Increment: " + no1.ToString());
            GUILayout.Label("FixUpdate Increment: " + no2.ToString());
            GUILayout.Label("Start At 1 Sec (Interval 1): " + no3.ToString());
            GUILayout.Label("Start At 5 Sec (Interval 0.5): " + no4.ToString());
            GUILayout.Label("Start At 10 Sec (No Looping): " + no5.ToString());
        }
        else
        {

            GUILayout.Label("Hitung Mundur: " + hitungMundur.ToString());
        }
        GUILayout.EndArea();
    }
}
