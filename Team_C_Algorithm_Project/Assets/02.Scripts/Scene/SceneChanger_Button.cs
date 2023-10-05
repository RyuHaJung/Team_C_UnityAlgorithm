using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_Button : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Test_01");
    }
}
