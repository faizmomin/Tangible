using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene(sceneName: "Guitar");
        } else if (Input.GetKey(KeyCode.C)) {
            SceneManager.LoadScene(sceneName: "Calculator");
        }
        else if (Input.GetKey(KeyCode.P)) {
            SceneManager.LoadScene(sceneName: "Ink");
        }

    }
}
