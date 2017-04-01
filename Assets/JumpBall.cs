using UnityEngine;
using System.Collections;

public class JumpBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Jump(float xSide)
	{
		this.rigidbody.AddRelativeForce(xSide, 5f, 0f, ForceMode.Impulse);
	}

	void ScreenSide()
	{

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			if(Input.mousePosition.x<=(Screen.width/2))
				Jump(0.6f);
			else
				Jump(-0.6f);
		}
	
	}
}
