using UnityEngine;

public class objectBehavior : MonoBehaviour
{
    public Vector3 test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        test = new Vector3(0f, -11.61f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < test.y)
        {
            Debug.Log("hi");
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
   
}
