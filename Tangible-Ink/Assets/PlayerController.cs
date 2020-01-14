using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jump = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int moveLeft = Input.GetKey(KeyCode.A) ? 1 : 0;
        int moveRight = Input.GetKey(KeyCode.D) ? 1 : 0;
        transform.position += Vector3.right * (moveRight - moveLeft) * 5 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W))
        {

            rb.AddForce(Vector2.up * jump);

        }

        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene(sceneName: "Home");
        }
    }
}
