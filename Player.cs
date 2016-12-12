using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int speed = 10;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
    if (Input.GetKey(KeyCode.A))
       {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
       }
    if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
	}
}
