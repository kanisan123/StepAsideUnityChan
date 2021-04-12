using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        unitychan = GameObject.Find("unitychan");
        difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y, unitychan.transform.position.z - difference);
    }
}
