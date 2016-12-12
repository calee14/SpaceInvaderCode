using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * 20 * Time.deltaTime);
        if(Camera.main.WorldToViewportPoint(this.transform.position).y > 1)
        {
            Destroy(this.gameObject);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Box"))
        {
            //Destroy(other.gameObject);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
