using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject circle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnCircle()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(circle);
            circle.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
