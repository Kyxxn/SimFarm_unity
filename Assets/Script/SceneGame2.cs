using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGame2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Game2");
    }
}
