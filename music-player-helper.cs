using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Awake()
    {
        if (FindObjectsByType<MusicPlayer>(FindObjectsSortMode.None).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
