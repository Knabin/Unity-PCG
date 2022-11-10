using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public Text textString;

    // Start is called before the first frame update
    void Start()
    {
        textString.text = "Hello World!";
    }
}
