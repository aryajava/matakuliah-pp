using UnityEngine;
using UnityEngine.UI;

public class KlikUI : MonoBehaviour
{
    public GameObject txtTarget, TxtInput;

    public void ClickMe()
    {
        txtTarget.GetComponent<Text>().text = TxtInput.GetComponent<InputField>().text;
    }

}
