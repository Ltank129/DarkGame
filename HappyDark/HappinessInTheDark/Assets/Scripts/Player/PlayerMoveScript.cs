using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {

	public float walkSpeed = 1.0f;
	Vector2 WalkDir = Vector2.zero;
	Rigidbody2D riggy;
	// Use this for initialization
	void Start () {
		riggy = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		WalkDir.x = Input.GetAxis ("Horizontal");
		WalkDir.y = Input.GetAxis ("Vertical");
		riggy.velocity = walkSpeed * WalkDir;
		Vector2 mousePos = Input.mousePosition;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90);

	}
}
