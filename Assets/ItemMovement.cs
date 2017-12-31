using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {

    public Transform _thisItem;
    // Use this for initialization
    public float _speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = _thisItem.transform.position;
        pos = new Vector3(pos.x, pos.y, pos.z + _speed);
        _thisItem.transform.position = pos;
	}
}
