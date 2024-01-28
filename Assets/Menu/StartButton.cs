using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : Button
{

    public override void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
