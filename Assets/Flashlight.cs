using UnityEngine;
using TMPro;
public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;
    public AudioSource source;
    public float charge;
    public TextMeshPro chargeText;

    

    void Update()
    {
        light.enabled = isOn;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }
        if(isOn)
        {
            charge-=5*Time.deltaTime;
        }
        if(charge<=0)
        {
            isOn = false;
        }
        light.intensity= charge/15;
        int chargeINT = (int)charge;
        

        if(chargeINT <= 0)
        {
            chargeText.text="0%";
        }
        else if(chargeINT > 0)
        {
            chargeText.text = chargeINT.ToString()+"%";
        }
        



    }

    void Switch()
    {
        if (charge <= 0)
        {
            isOn = false;
        }

        isOn = !isOn;
        source.Play();

    }
}