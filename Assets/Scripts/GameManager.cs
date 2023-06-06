using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Yes! Game just started");
        // I think I want some text here
    }

    private void OnDestroy()
    {
        Debug.Log("Oh no! Game closed");
        // And I also want some text here tho!
    }
}
