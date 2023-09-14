using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Text mainText;
    public Button option1;
    public Button option2;


    // Start is called before the first frame update
    void Start()
    {
        mainText.text="Welcome to my game!";
        option1.GetComponentInChildren<mainText>().text = "Hello";
        option2.GetComponentInChildren<mainText>().text = "Bye!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
