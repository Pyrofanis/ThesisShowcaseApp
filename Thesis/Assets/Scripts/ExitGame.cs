using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CloseGame();
    }
    private void CloseGame()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();


        }
    }
}
