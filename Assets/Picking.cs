using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {

    public Camera pickingCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0) == true)
        {
            // Create a ray at the mouse position.
            Vector3 mousePosition = Input.mousePosition;
            Ray pickingRay = pickingCamera.ScreenPointToRay(mousePosition);

            // Use the ray to see if anything is hit.
            RaycastHit hit;
            bool success = Physics.Raycast(pickingRay, out hit);

            if (success)
            {
                Debug.Log("The name of the picked object is " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Tooth")
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
	}
}
