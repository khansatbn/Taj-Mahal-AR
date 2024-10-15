using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSettings : MonoBehaviour
{
    public GameObject tajIND, tajEng;

    // Start is called before the first frame update
    void Start()
    {
        tajIND.SetActive(true);
        tajEng.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void indButton()
    {
        if (tajIND == null)
        {
            bool isActive = tajIND.activeSelf;
            tajIND.SetActive(isActive);
        }

        else
        {
            tajEng.SetActive(false);
            tajIND.SetActive(true);
        }
    }

    public void engButton()
    {
        if (tajEng == null)
        {
            bool isActive = tajEng.activeSelf;
            tajEng.SetActive(isActive);
        }

        else
        {
            tajIND.SetActive(false);
            tajEng.SetActive(true);
        }
    }
}
