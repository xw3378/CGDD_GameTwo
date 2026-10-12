using UnityEngine;
using UnityEngine.UI;

public class UI_swap : MonoBehaviour
{
    public Button MyButton;
    public Canvas CanvasToSwapTo;
    private Canvas canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        MyButton.onClick.AddListener(ResetScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetScene()
    {
        canvas.gameObject.SetActive(false);
        CanvasToSwapTo.gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        MyButton.onClick.RemoveListener(ResetScene);
    }
}
