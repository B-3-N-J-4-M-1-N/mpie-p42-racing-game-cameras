using UnityEngine;

public class Static_Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform t = gameObject.transform;
        t.position = new Vector3 (0.0f, 200.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // find the object we want to look at
        GameObject target = GameObject.Find("Car_P1");
        // get the current game object's (e.g. the camera) 
        // transform and make it look at the target's transform
        gameObject.transform.LookAt(target.transform);

    }
}
