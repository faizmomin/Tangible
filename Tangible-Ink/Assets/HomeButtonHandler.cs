using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene(sceneName: "Home");
        }
    }

    public void LoadHome(bool a)
    {
        SceneManager.LoadScene(sceneName: "Home");
    }
}

