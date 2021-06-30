using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Tooltip : MonoBehaviour
{
   public TextMeshProUGUI contentText;
   public TextMeshProUGUI headerText;
   public LayoutElement layoutElement;
   public int characterWrapLimit;
   public RectTransform rectTransform;
   
   [TextArea]
   [SerializeField] private string text;

   private void Awake()
   {
       rectTransform = GetComponent<RectTransform>();
   }

   private void Start()
    {
        ShowTooltip(text);
    }

    private void ShowTooltip(string tooltipString)
    {
        gameObject.SetActive(true);

    }

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

    public void SetText(string content, string header = "")
    {
        headerText.gameObject.SetActive(!string.IsNullOrEmpty(header));

        headerText.text = header;
        contentText.text = content;
        
        var headerLength = headerText.text.Length;
        var contentLength = contentText.text.Length;

        layoutElement.enabled =
            (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
    }

    private void Update()
    {
        Vector2 position = Input.mousePosition;

        var pivotX = position.x / Screen.width;
        var pivotY = position.y / Screen.height - 0.3F;

        rectTransform.pivot = new Vector2(pivotX, pivotY);
        transform.position = position;
    }
}
