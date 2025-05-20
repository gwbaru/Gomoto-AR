using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBGM : MonoBehaviour
{
    private Sprite soundOffImage;
    public Sprite soundOnImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audiosource;

    void Start()
    {
        soundOffImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOnImage;
            isOn = false;
            audiosource.Stop();
        }
        else
        {
            button.image.sprite = soundOffImage;
            isOn = true;
            audiosource.Play();
        }
    }
}
