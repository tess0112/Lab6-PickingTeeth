using UnityEngine;
using System.Collections;

public class Tilt : MonoBehaviour {
  private Vector2 _initialMousePosition;
  public float rotationConstraint = 36.0f;

	// Use this for initialization
    void Start () {
        _initialMousePosition = Input.mousePosition;
	}

  // Update is called once per frame
  void Update() {
    Vector2 currentMousePosition = Input.mousePosition;
    Vector2 delta = currentMousePosition - _initialMousePosition;

    if(Mathf.Abs(delta.x) > rotationConstraint) {
      delta.x = Mathf.Sign(delta.x) * rotationConstraint;
    }

    if(Mathf.Abs(delta.y) > rotationConstraint) {
      delta.y = Mathf.Sign(delta.y) * rotationConstraint;
    }

    Vector3 localRotation = new Vector3(delta.y, 0.0f, -delta.x);
    transform.localRotation = Quaternion.Euler(localRotation);
	}
}
