using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void ChangeToMain()
    {
        LoadingSceneManager.LoadScene("Main");
    }

    public void ChangeToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ChangeToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void ChangeToHowToPlay2()
    {
        SceneManager.LoadScene("HowToPlay2");
    }
    public void ChangeToCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void CHangeToHowToPlay3()
    {
        SceneManager.LoadScene("HowToPlay3");
    }

}


