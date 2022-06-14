using UnityEngine;

public class RaycastCube : MonoBehaviour
{
    Ray myRay;
    RaycastHit myRH;
    public GameObject target;
    public bool isDebug = true, isMoving = false;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(myRay, out myRH, 300);
            target.transform.position = myRH.point + new Vector3(0, 0.1f, 0);
            transform.LookAt(target.transform);
        }
        if (isMoving && Vector3.Distance(transform.position, target.transform.position) > 0.6f)
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 10 * Time.deltaTime);
        if (isDebug)
            Debug.DrawLine(GameObject.Find("Main Camera").gameObject.transform.position, myRH.point, Color.red);
    }
}
