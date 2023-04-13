using UnityEngine; 
public class audioScript : MonoBehaviour 
{     
    AudioSource audioSource;  
    void Start()     
    { 
        audioSource = GetComponent<AudioSource>();     
    } 
    void Update()     
    { 
        if (Input.GetButtonDown("Jump")) 
            { 
                if (audioSource.isPlaying == true)                 
                    audioSource.Stop(); 
                else
                    audioSource.Play();         
            }     
    } 
}