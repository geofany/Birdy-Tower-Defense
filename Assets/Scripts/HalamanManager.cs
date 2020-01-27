using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MulaiPermainan() {
        Data.isGameOver = false;
        Data.isComplete = false;
        Data.coin = 0;
        SceneManager.LoadScene("Gameplay");
    }

    public void KembaliKeMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void KeluarPermainan(){
        Application.Quit();
    }


}
