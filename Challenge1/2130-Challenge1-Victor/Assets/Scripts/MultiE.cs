using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiE : MonoBehaviour
{

    public void ExitedMulti()
    {

        SceneManager.LoadScene("SampleScene");

        //GameObject.Find("Background").GetComponent<Image>().color = b;
    }


}
