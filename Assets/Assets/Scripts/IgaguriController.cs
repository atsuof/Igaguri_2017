using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour {

    public void shoot(Vector3 dir)
    {
		GetComponent<Rigidbody>().AddForce(dir);
    }

	// Use this for initialization
	void Start () {
		//shoot(new Vector3(0, 200, 2000));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.name.Equals("target"))
		{
			GetComponent<Rigidbody>().isKinematic = true;
		}
		GetComponent<ParticleSystem>().Play();

    }
}
