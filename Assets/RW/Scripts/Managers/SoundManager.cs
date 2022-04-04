using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip ShootClip;
    public AudioClip sheepHitClip;
    public AudioClip sheepDroppedClip;

    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }
    public void PlayShootClip()
    {
        PlaySound(ShootClip);
    }
    public void PlaySheepHitClip()
    {
        PlaySound(sheepHitClip);
    }
    public void PlaySheepDroppedClip()
    {
        PlaySound(sheepDroppedClip);
    }
}
