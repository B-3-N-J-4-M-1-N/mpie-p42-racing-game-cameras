using UnityEngine;

public class DungeonCrawler_Camera : MonoBehaviour
{
    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // find the object we want to look at
        GameObject target = GameObject.Find("Car_P2");

        offset = transform.position - target.transform.position;


        Transform t = gameObject.transform;
        t.position = new Vector3 (111.7f, 50.0f, 25.7f);

        transform.rotation = Quaternion.Euler(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // find the object we want to look at
        GameObject target = GameObject.Find("Car_P2");

        Vector3 newPos = target.transform.position + offset;
        transform.position = newPos;

    }
}
