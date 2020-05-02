using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour
{

    private AudioSource[] _audioSources;
    private AudioClip[] _audioClips;
    private AudioSource playerWalkSource;
    private AudioSource playerFlySource;
    private AudioSource playerJumpSource;
    private AudioSource playerFireSource;

    // Start is called before the first frame update

    void Start()
    {
        _audioSources = GetComponents<AudioSource>();
        playerWalkSource = _audioSources[1];
        playerFlySource = _audioSources[2];
        playerJumpSource = _audioSources[0];
        playerFireSource = _audioSources[3];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
        {
            PlaySound("Walk");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S))
        {
            StopSound("Walk");
        }

        if (Input.GetButton("Fire1"))
        {
            PlaySound("Fire");
        }
        if (Input.GetButton("Jump"))
        {
            PlaySound("Jump");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlaySound("Fly");
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            StopSound("Fly");
        }
    }

    public void PlaySound(string soundType)
    {
        switch (soundType)
        {
            case "Walk":
                if (!playerWalkSource.isPlaying)
                    playerWalkSource.Play();
                break;
            case "Fly":
                if (!playerFlySource.isPlaying)
                    playerFlySource.Play();
                break;
            case "Jump":
                if (!playerJumpSource.isPlaying)
                    playerJumpSource.Play();
                break;
            case "Fire":
                if (!playerFireSource.isPlaying)
                    playerFireSource.Play();
                break;
        }
    }

    public void StopSound(string soundType)
    {
        switch (soundType)
        {
            case "Walk":
                if (playerWalkSource.isPlaying)
                    playerWalkSource.Stop();
                break;
            case "Fly":
                if (playerFlySource.isPlaying)
                    playerFlySource.Stop();
                break;
            case "Jump":
                if (playerJumpSource.isPlaying)
                    playerJumpSource.Stop();
                break;
            case "Fire":
                if (playerFireSource.isPlaying)
                    playerFireSource.Stop();
                break;
        }
    }
}
