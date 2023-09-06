using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextScene : MonoBehaviour
{
    public void ChangeNextScene()
    {
        int curSceneNum = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scene"+(curSceneNum + 1));
    }
}
