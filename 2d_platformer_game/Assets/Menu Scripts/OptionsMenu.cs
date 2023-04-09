using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle fullscreenTog, vsyncTog;

    public List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution;

    public TextMeshProUGUI resolutionLabel;

    public AudioMixer theMixer;

    public TextMeshProUGUI MasterLabel, MusicLabel, SFXLabel;

    public Slider MasterSlider, MusicSlider, SFXSlider;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;

        if(QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        }
        else
        {
            vsyncTog.isOn = true;
        }

        bool foundRes = false;
        for(int i = 0; i < resolutions.Count; i++)
        {
            if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                foundRes = true;

                selectedResolution= i;

                UpdateResLabel();
            }
        }

        if ( !foundRes ) {
            ResItem newRes = new ResItem();
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;

            resolutions.Add(newRes);
            selectedResolution = resolutions.Count -1;

            UpdateResLabel();
        }


        float vol = 0f;
        theMixer.GetFloat("MasterVol", out vol);
        MasterSlider.value = vol;

        theMixer.GetFloat("MusicVol", out vol);
        MusicSlider.value = vol;

        theMixer.GetFloat("SFXVol", out vol);
        SFXSlider.value = vol;

        MasterLabel.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();
        MusicLabel.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();
        SFXLabel.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResLeft()
    {
        selectedResolution--;
        if (selectedResolution < 0) 
        {
            selectedResolution = 0;
        }
        UpdateResLabel();
    }

    public void ResRight()
    {
        selectedResolution++;
        if (selectedResolution > resolutions.Count -1) 
        {
            selectedResolution = resolutions.Count -1;
        }
        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
    }

    public void ApplyGraphics()
    {
        //Screen.fullScreen = fullscreenTog.isOn;

        if(vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }

        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenTog.isOn);
    }
    public void SetMasterVol()
    {
        MasterLabel.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();
        
        theMixer.SetFloat("MasterVol", MasterSlider.value);

        PlayerPrefs.SetFloat("MasterVol", MasterSlider.value);
    }

    public void SetMusicVol()
    {
        MusicLabel.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();

        theMixer.SetFloat("MusicVol", MusicSlider.value);

        PlayerPrefs.SetFloat("MusicVol", MusicSlider.value);
    }

    public void SetSFXVol()
    {
        SFXLabel.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();

        theMixer.SetFloat("SFXVol", SFXSlider.value);

        PlayerPrefs.SetFloat("SFXVol", SFXSlider.value);
    }
}
[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}