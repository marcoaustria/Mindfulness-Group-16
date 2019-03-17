using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PikaSceneChange : MonoBehaviour
{
    private bool tracked;
    // Start is called before the first frame update
    public string sceneName;
    void Start()
    {
        tracked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(tracked && Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void pointerEntered(){

        tracked = true;
    }

    public void pointerExited()
    {
        tracked = false;
    }


}
