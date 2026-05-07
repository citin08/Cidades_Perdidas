using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public Text mission;
    public Image icon;
    public Image altIcon;

    public bool hasCollectedArtifact;


    // Start is called before the first frame update
    void Start()
    {
        hasCollectedArtifact = false;
        mission.text = "Missão atual: Explorar e encontrar o artefato";
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCollectedArtifact == true)
        {
            mission.text = "Missão atual: Escapar do guardião";
            icon.gameObject.SetActive(false);
            altIcon.gameObject.SetActive(true);
        }
    }
}
