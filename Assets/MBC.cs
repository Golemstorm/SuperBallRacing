using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBC : MonoBehaviour
{
    public Transform balltransform;
     public Transform cameratransform;
    // Start is called before the first frame update
    private Vector3 offset;
    void Start()
    {
        offset = cameratransform.position - balltransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cameratransform.position = offset + balltransform.position;
    }
}
