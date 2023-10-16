using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zombies : MonoBehaviour
{
    [SerializeField] Text live;
    [SerializeField] Text split;
    [SerializeField] Text system;
    [SerializeField] Text solo;

    [SerializeField] GameObject light;

    [SerializeField] GameObject panel;
    [SerializeField] Color z;
    [SerializeField] Color b;

    public bool zombiesSelected = false;

    public bool isInfected = false;

  //  public bool multiSelected = false;

    public bool campaignSelected = false;

    public Animator glare;
    public Animator infected;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (zombiesSelected)
        {
            panel.SetActive(true);
            glare.SetBool("zombiesSelected", zombiesSelected);
            infected.SetBool("isInfected", zombiesSelected);

        }
        else
        {
            panel.SetActive(false);
            glare.SetBool("zombiesSelected", zombiesSelected);
            infected.SetBool("isInfected", zombiesSelected);

        }


      


        if (Input.GetKeyDown(KeyCode.T))
        {

            ExitedZombies();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void SelectedZombies()
    {
        zombiesSelected = true;
        //isInfected = true;
        live.text = "XBox Live";
        split.text = "Split Screen";
        system.text = "System Link";
        solo.text = "Solo";

        light.GetComponent<Light>().color = z;
        
    }

    public void ExitedZombies()
    {
        zombiesSelected = false;
       // isInfected = false;
        live.text = "Campaign";
        split.text = "Multiplayer";
        system.text = "Zombies";
        solo.text = "Options";

        light.GetComponent<Light>().color = b;


        //GameObject.Find("Background").GetComponent<Image>().color = b;
    }

    public void SelectedMulti()
    {
       
        SceneManager.LoadScene("Multi");

        //GameObject.Find("Background").GetComponent<Image>().color = z;

    }

  
    public void SelectedCampaign()
    {
        campaignSelected = true;
        live.text = "Solo";
        split.text = "System Link";
        system.text = "Split Screen";
        solo.text = "Back";
    }

    public void ExitedCampaign()
    {
        if(campaignSelected)
        {
            campaignSelected = false;

            live.text = "Campaign";
            split.text = "Multiplayer";
            system.text = "Zombies";
            solo.text = "Options";
        }

       

      
    }
}
