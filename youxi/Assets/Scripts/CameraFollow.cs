using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform Target;
	private float smooth = 1;

	void Awake()
	{
		Target = GameObject.Find ("motobody").transform;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position,new Vector3 (Target.position.x,transform.position.y, transform.position.z), Time.deltaTime * smooth);
	}
}
