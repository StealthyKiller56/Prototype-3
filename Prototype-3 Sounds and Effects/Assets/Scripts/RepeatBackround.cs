using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackround : MonoBehaviour
{

    private Vector3 _StartPos;
    private float _repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        _StartPos = transform.position;
        _repeatWidth = GetComponent<BoxCollider>().size.x / 2; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _StartPos.x - _repeatWidth)
        {
            transform.position = _StartPos;
        }
    }
}
