using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRandomForce : MonoBehaviour
{

    // Start is called before the first frame update
    private Vector3 pos;
    public GameObject obj;
    void Start()
    {
        pos = obj.transform.position;
        pos = new Vector3(pos.x+Random.Range(-5.0f, 5.0f), pos.y, pos.z+Random.Range(-5.0f, 5.0f));
        transform.position = pos;
    }
}
