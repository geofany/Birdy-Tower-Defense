using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public Text info;
    // Start is called before the first frame update
    void Start()
    {
        if (Data.isComplete){
            info.text = "Congratulations \n You Win!";

        }
        else {
            info.text = "Game Over \n You Lose!";
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
