using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    public GameObject posisiTembak, Peluru;
    GameObject kamera, temp;
    bool keKanan = true;

    void Start()
    {
        kamera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (keKanan)
        {
            kamera.transform.Rotate(0, 0.3f, 0);
            if (kamera.transform.eulerAngles.y > 0)
            {
                keKanan = false;
            }
            else
            {
                kamera.transform.Rotate(0, -0.3f, 0);
                if (kamera.transform.eulerAngles.y < 0) keKanan = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            temp = (GameObject)GameObject.Instantiate(
                Peluru, posisiTembak.transform.position, posisiTembak.transform.rotation
            );
            Destroy(temp, 1);
        }
        if (temp)
        {
            temp.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 300);
        }
    }
}
