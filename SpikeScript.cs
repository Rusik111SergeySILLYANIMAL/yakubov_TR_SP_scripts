using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene("SampleScene");
    }
}
