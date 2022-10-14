using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public GameObject obj;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
        offset.x += 30* Time.fixedDeltaTime;
        if (offset.x > 360)
            offset.x -= 360;
        offset.y += 30 * Time.fixedDeltaTime;
        if (offset.y > 360)
            offset.y -= 360;
        //offset.z += 30 * Time.fixedDeltaTime;
        obj.transform.eulerAngles = offset;
    }
}
