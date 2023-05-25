using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Special_Skip : MonoBehaviour
{

    [SerializeField] private string defaultScene;
    [SerializeField] private string cutWireScene;
    private string sceneToPlay;
    private bool purpleWireIsConnected;

    // Start is called before the first frame update
    void Start()
    {
        purpleWireIsConnected = Check_Camera_Wire.GetWireStatus();
        if(purpleWireIsConnected == true)
        {
            sceneToPlay = defaultScene;
        }
        else
        {
            sceneToPlay = cutWireScene;
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToPlay);
    }
}
