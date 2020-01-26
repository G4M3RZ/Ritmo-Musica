using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;

    //test cambio
    public int Radio;
    public float SpawnerRotate;
    public int ObjInstantiateLimit;

    //rotacion
    public bool _rotar;
    public float _velocidadRotacion;
    public bool _invertirRotacion;

	// Use this for initialization
	void Start ()
    {
		for(int i = 0; i < ObjInstantiateLimit; i++)
        {
            GameObject _instantiateSampleCubes = (GameObject)Instantiate(_sampleCubePrefab);
            _instantiateSampleCubes.transform.position = this.transform.position;
            _instantiateSampleCubes.transform.parent = this.transform;
            _instantiateSampleCubes.name = "SampleCume" + i;
            this.transform.eulerAngles = new Vector3(0, SpawnerRotate * i, 0);
            _instantiateSampleCubes.transform.position = Vector3.forward * Radio;
            _sampleCube[i] = _instantiateSampleCubes;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		for(int i=0; i < ObjInstantiateLimit; i++)
        {
            if(_sampleCube != null)
            {
                _sampleCube[i].transform.localScale = new Vector3(10, (AudioPeer._samples[i] * _maxScale) + 2, 10);
            }
        }
        if (_rotar)
        {
            MovimientoNaranja();
        }
    }
    void MovimientoNaranja()
    {
        if (_invertirRotacion)
        {
            transform.Rotate(0, -_velocidadRotacion * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, _velocidadRotacion * Time.deltaTime, 0);
        }
    }
}
