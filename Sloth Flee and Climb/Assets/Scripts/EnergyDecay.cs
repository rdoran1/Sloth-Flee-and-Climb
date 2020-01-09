using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyDecay : MonoBehaviour
{
    public Text energyText;
    private float energy;
    // Start is called before the first frame update
    void Start()
    {
        energy = 100;
        UpdateEnergy();
    }
    

    public void EnergyLoss()
    {
        energy--;
        UpdateEnergy();
    }

    public void EnergyGain()
    {
        energy = 100;
        UpdateEnergy();
    }

    void UpdateEnergy()
    {
        energyText.text = "Energy: " + energy + "/100";
    }
}
