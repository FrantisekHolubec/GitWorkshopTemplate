using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private Button _Button;

    private void Awake()
    {
        _Button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDestroy()
    {
        _Button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.Log("Yeah! Button pressed");
    }
}
