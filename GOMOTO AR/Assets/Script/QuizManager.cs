using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    void Start()
    {
       PlayerPrefs.SetInt ("skor", 0);
    }
}
