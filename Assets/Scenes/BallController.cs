using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("User's Input: W");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("User's Input: A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("User's Input: S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("User's Input: D");
        }
    }
}
