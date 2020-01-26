using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSuelo : MonoBehaviour {
    public float _rotacioSpeed;
    public bool _sentidoContrario;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!_sentidoContrario)
        {
            transform.Rotate(0, _rotacioSpeed *Time.deltaTime , 0);
        }
        else
        {
            transform.Rotate(0, -_rotacioSpeed * Time.deltaTime * 2, 0);
        }
	}
}
