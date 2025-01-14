using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Button simulation1Button;
    [SerializeField] private Button simulation2Button;
    [SerializeField] private TextMeshProUGUI titleText;
    
    private void Start()
    {
        SetupButtons();
    }

    private void SetupButtons()
    {
        simulation1Button.onClick.AddListener(() => LoadSimulation(1));
        simulation2Button.onClick.AddListener(() => LoadSimulation(2));
    }

    private void LoadSimulation(int simulationNumber)
    {
        // Store selected simulation number for reference
        PlayerPrefs.SetInt("SelectedSimulation", simulationNumber);
        PlayerPrefs.Save();
        
        // Load the corresponding simulation scene
        SceneManager.LoadScene($"Simulation{simulationNumber}");
    }
}
