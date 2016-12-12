using UnityEngine;
using System.Collections;

public class LazerScript : MonoBehaviour {

    private Lives playerScript;
	// Use this for initialization
	void Start () {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Lives>();
	}
	
	// Update is called once per frame
	void Update () {
        
            transform.Translate(Vector3.down * 10 * Time.deltaTime);
            if (Camera.main.WorldToViewportPoint(this.transform.position).y > 1)
            {
                Destroy(this.gameObject);
            }

        }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit!");
            //Destroy(other.gameObject); 
            Destroy(this.gameObject);
            playerScript.LoseLives();
            
        }
        if (other.gameObject.CompareTag("Box"))
        {
            Debug.Log("Hit!");
            Destroy(this.gameObject);
            
        }
    }



}
