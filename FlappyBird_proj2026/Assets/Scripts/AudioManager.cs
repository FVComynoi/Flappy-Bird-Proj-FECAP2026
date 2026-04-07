using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioClip flySound;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip score;
    [SerializeField] private AudioClip die;
    private AudioSource audioSource;
    void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayFlyingSound() => audioSource.PlayOneShot(flySound);
    public void PlayHitSound() => audioSource.PlayOneShot(hitSound);
    public void PlayScoreSound() => audioSource.PlayOneShot(score);
    public void PlayDieSound() => audioSource.PlayOneShot(die);
}