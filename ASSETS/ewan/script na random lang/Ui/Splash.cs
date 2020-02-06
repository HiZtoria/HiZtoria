using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        Application.LoadLevel(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
