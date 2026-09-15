using UnityEngine;

public class objectBehavior : MonoBehaviour
{
    public Vector2 test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        test = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        transform.position = new Vector3 (2.9f, 9.39f,0f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
