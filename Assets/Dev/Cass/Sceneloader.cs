using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int targetScene;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
            SceneManager.LoadScene(targetScene);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
