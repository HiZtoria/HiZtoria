using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuicyStudioScene : MonoBehaviour {

    // Use this for initialization



    void Update()
    {
        StartCoroutine(LoadNewScene());

    }

    private IEnumerator LoadNewScene() {
        yield return new WaitForSeconds(3.0f);
        //Application.LoadLevel(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("1");
        //SceneManager.LoadScene("Main");
        //Application.LoadLevel("Main");
        //SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        //EditorApplication.OpenScene(1);
    }
}
