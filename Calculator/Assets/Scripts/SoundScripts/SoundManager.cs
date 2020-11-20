using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip[] s_AudioList;

    List<AudioSource> s_Source = new List<AudioSource>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < s_AudioList.Length; i++)
        {
            s_Source.Add(new AudioSource());
            s_Source[i] = gameObject.AddComponent<AudioSource>();
            s_Source[i].clip = s_AudioList[i];

        }
    }

    public void PlaySound(int s)
    {
        s_Source[s].Play();
    }

}
