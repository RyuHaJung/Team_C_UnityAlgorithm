using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_Retry : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Map1");
    }
}
