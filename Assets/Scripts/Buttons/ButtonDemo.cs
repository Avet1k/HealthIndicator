using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonDemo : MonoBehaviour
{
    [SerializeField] protected Health PersonHealth;
    [SerializeField] protected int Amount;

    protected Button ButtonAction;

    private void Awake()
    {
        ButtonAction = GetComponent<Button>();
    }

    private void OnEnable()
    {
        ButtonAction.onClick.AddListener(Action);
    }

    private void OnDisable()
    {
        ButtonAction.onClick.RemoveListener(Action);
    }

    protected abstract void Action();
}
