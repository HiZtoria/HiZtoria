using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour {


	public static float countTimer = 0;


    //NUMBERS
	public GameObject Num_A;   
	public GameObject Num_B;   
	public GameObject Num_C;   
	public GameObject Num_GO;

	void Start ()
	{
		//timerrr
		countTimer = 0;

		Num_A.SetActive(false);
		Num_B.SetActive(false);
		Num_C.SetActive(false);
		Num_GO.SetActive(false);

	}

	void Update ()
	{
		if (SceneManager.isPause) {
			Num_A.SetActive(false);
			Num_B.SetActive(false);
			Num_C.SetActive(false);
			Num_GO.SetActive(false);
			countTimer = 0;

		} else {
			if (countTimer == 0) {
				Time.timeScale = 0.0f;  
			}

			if (countTimer <= 90) {
				countTimer++;
	
				if (countTimer < 30) {
					Num_C.SetActive (true);
				}
	
				if (countTimer > 30) {
					Num_C.SetActive (false);
					Num_B.SetActive (true);
				}

				if (countTimer > 60) {
					Num_B.SetActive (false);
					Num_A.SetActive (true);
				}
			
				if (countTimer >= 90) {
					Num_A.SetActive (false);
					Num_GO.SetActive (true);
					StartCoroutine (this.LoadingEnd ());
					Time.timeScale = 1.0f;
				}
			}
		}
	}

	IEnumerator LoadingEnd(){

		yield return new WaitForSeconds(1.0f);
		Num_GO.SetActive(false);
	}

}
