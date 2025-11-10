using UnityEngine;
using UnityEngine.SceneManagement;

public class WallAudio : MonoBehaviour
{
    public AudioClip hit;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        BlockID block = other.gameObject.GetComponent<BlockID>();

        if (block != null)
        {
            if (block.blockID == 0)
            {
                audioSource.PlayOneShot(hit);
            }
        }
    }
}
