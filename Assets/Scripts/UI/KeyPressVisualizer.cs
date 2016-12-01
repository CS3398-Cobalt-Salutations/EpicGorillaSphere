using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class KeyPressVisualizer : MonoBehaviour
{
    public KeyCode checkKey;

    public bool IsKeyPressed { get { return Input.GetKey(checkKey); } }

    private Button buttonScript;
    private ColorBlock colors;

    // Use this for initialization
    void Start()
    {
        buttonScript = GetComponent<Button>();
        colors = buttonScript.colors;
        colors.normalColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsKeyPressed) colors.normalColor = Color.red;
        else colors.normalColor = Color.white;
    }
}
