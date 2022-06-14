using UnityEngine;

public class AnimationCube : MonoBehaviour
{
    Animator myAnim;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 100, 200));
        if (GUILayout.Button("Animasi - 1")) myAnim.Play("Animasi1");
        if (GUILayout.Button("Animasi - 2")) myAnim.Play("Animasi2");
        if (GUILayout.Button("Animasi - 3")) myAnim.Play("Animasi3");
        GUILayout.EndArea();
    }

}
