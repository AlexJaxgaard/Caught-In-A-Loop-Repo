using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Check_Camera_Wire : MonoBehaviour
{

    [SerializeField] private static bool purpleWireConnect;
    private VideoPlayer videoPlayer;

    public void PurpleDisconnect()
    {
        purpleWireConnect = false;
    }

    public void YellowDisconnect()
    {
        purpleWireConnect = true;
    }

    public static bool GetWireStatus()
    {
        return purpleWireConnect;
    }
}
