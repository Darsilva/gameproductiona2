using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--- Audio Source ---")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--- Audio Clip ---")]
    public AudioClip backmusic;
    public AudioClip click;

    private void Start()
    {
        musicSource.clip = backmusic;
        musicSource.Play();
    }
  
}