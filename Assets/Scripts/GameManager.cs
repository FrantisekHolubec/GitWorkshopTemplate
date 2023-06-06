using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Yes! Game just started");
        // This game is lovely
        // But this comment is useless
    }

    private void OnDestroy()
    {
        Debug.Log("Oh no! Game closed");
    }
}
