using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour

{
    [SerializeField] private int targetBlock = 0;
    [SerializeField] private string nextScene = "lvl 2";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Other)
    {
        Debug.Log("cld");
        BlockID block = Other.gameObject.GetComponent<BlockID>();

        if (block != null)
        {
            if (block.blockID == targetBlock)
            {
                Debug.Log("ooooo");
                SceneManager.LoadScene(nextScene);
            }   
        }
    }
}
