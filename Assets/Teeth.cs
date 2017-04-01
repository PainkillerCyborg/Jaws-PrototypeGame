	using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Teeth : MonoBehaviour {

	public List<GameObject> LeftTeeth01 = new List<GameObject>();
	public List<GameObject> LeftTeeth02 = new List<GameObject>();
	public GameObject LeftTeethJaw01, LeftTeethJaw02;
	// Use this for initialization
	void Start () {
		StartCoroutine(Bites());
	}

	void Bite()
	{
		int rand = Random.Range(0, 3);
		int rand02 = Random.Range(0,3);
		Debug.Log("Rand: "+rand);
		if(rand==0)
		{
			for(int i=0; i<LeftTeeth01.Count; i++)
			{
				LeftTeeth01[i].SetActive(true);
			}
			LeftTeethJaw01.SetActive(true);
		}
		else
		{

			for(int i=0; i<rand; i++)
			{

				int r;
				do
				{
					r = Random.Range(0,3);
					LeftTeeth01[r].SetActive(true);
				}
				while(LeftTeeth01[r].activeSelf==false);
			}
			LeftTeethJaw01.SetActive(true);
		}

//		if(rand02==0)
//		{
//			for(int i=0; i<LeftTeeth02.Count; i++)
//			{
//				LeftTeeth02[i].SetActive(true);
//			}
//			LeftTeethJaw02.SetActive(true);
//		}
//		else
//		{
//			for(int i=0; i<rand02; i++)
//			{
//
//				int r;
//				do
//				{
//					r = Random.Range(0,3);
//					LeftTeeth02[r].SetActive(true);
//				}
//				while(LeftTeeth02[r].activeSelf==false);
//			}
//			LeftTeethJaw02.SetActive(true);
//		}
	}

	IEnumerator Bites()
	{
		yield return new WaitForSeconds(0.5f);
		Bite();
		yield return new WaitForSeconds(2.0f);
		LeftTeethJaw01.animation.Play("Tooth_Left_Out");
		yield return new WaitForSeconds(0.5f);
		LeftTeethJaw01.SetActive(false);
		for(int i=0; i<LeftTeeth01.Count; i++)
		{
			LeftTeeth01[i].SetActive(false);
		}
		yield return new WaitForSeconds(0.25f);
		StartCoroutine(Bites());
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
