using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock clock;
    private AudioSource chime;

    private void Start()
    {
        clock.OnTheHour.AddListener(Chime);
        chime = GetComponent<AudioSource>();
    }
    public void Chime(int hour)
    {
        Debug.Log("Chiming " + hour + " o'clock!");
        chime.Play();

    }
    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming !");
    }

    //IEnumerator CuckooBird()
   // {
        
   // }
}
