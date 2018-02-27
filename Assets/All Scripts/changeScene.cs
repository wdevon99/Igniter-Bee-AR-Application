using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour {



	void Start() {
		
	}

	//this method will chage the scene with the scene number is given
	public void chageToScene(int sceneNumber){

		//scene number is the number stated in the build settingd
		SceneManager.LoadScene(sceneNumber); //loading the scene
	}


	//this method check for the internet connectivity and change the scene if internet is available...or else a panel is set active as an error ,messgae
	public void chageToSceneToArCam(){

		//checking if internet is reachable or not
		if (Application.internetReachability == NetworkReachability.NotReachable) {


		} else{
			//scene number is the number stated in the build settingd
			SceneManager.LoadScene("loadingScene"); //loading the scene

		}
	
	}



	void update(){
		

	}


}
