using System;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private KillerProfile[] killers;
    [SerializeField] private Image killerPortrait;
    [SerializeField] private Image perk1;
    [SerializeField] private Image perk2;
    [SerializeField] private Image perk3;
    [SerializeField] private Image perk4;
    [SerializeField] private TextMeshProUGUI lore;
    [SerializeField] private GameObject killerList;
    [SerializeField] private GameObject killerPanel;
    [SerializeField] private GameObject backButton;
    [SerializeField] private TooltipTrigger perk1Tooltip;
    [SerializeField] private TooltipTrigger perk2Tooltip;
    [SerializeField] private TooltipTrigger perk3Tooltip;
    [SerializeField] private TooltipTrigger perk4Tooltip;

    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private TextMeshProUGUI button1Text;
    [SerializeField] private TextMeshProUGUI button2Text;
    [SerializeField] private TextMeshProUGUI button3Text;
    [SerializeField] private TextMeshProUGUI button4Text;

    [SerializeField] private RectTransform loreContent;

    private string _killer = "";
    private bool _back = false;
    private void Awake()
    {
        Screen.SetResolution( 1125, 674, false );
    }

    // Start is called before the first frame update
    void Start()
    {
        //killerList.SetActive(true);
        //killerPanel.SetActive(false);
    }

    private void Update()
    {
        if (_back == false)
        {
            backButton.SetActive(false);
        }
        else _back = true;
    }

    public void Back()
    {
        title.text = "Select Killer";
        _killer = "";
        killerList.SetActive(true);
        killerPanel.SetActive(false);
        _back = false;
    }
    
    public void KillerSelected()
    {
        InitiateKiller(EventSystem.current.currentSelectedGameObject.name);
    }
    
    private void InitiateKiller(string killer)
    {
        _back = true;
        _killer = killer;
        killerList.SetActive(false);
        killerPanel.SetActive(true);
        backButton.SetActive(true);

        if (killers[GetKiller()].build1Name != "")
        {
            button1.gameObject.SetActive(true);
            button1Text.text = killers[GetKiller()].build1Name;
        }
        else
        {
            button1.gameObject.SetActive(false);
        }

        if (killers[GetKiller()].build2Name != "")
        {
            button2.gameObject.SetActive(true);
            button2Text.text = killers[GetKiller()].build2Name;
        }
        else
        {
            button2.gameObject.SetActive(false);
        }
        
        if (killers[GetKiller()].build3Name != "")
        {
            button3.gameObject.SetActive(true);
            button3Text.text = killers[GetKiller()].build3Name;
        }
        else
        {
            button3.gameObject.SetActive(false);
        }
        
        if (killers[GetKiller()].build4Name != "")
        {
            button4.gameObject.SetActive(true);
            button4Text.text = killers[GetKiller()].build4Name;
        }
        else
        {
            button4.gameObject.SetActive(false);
        }

        killerPortrait.sprite = killers[GetKiller()].Icon;
        perk1.sprite = killers[GetKiller()].perk1.icon;
        perk2.sprite = killers[GetKiller()].perk2.icon;
        perk3.sprite = killers[GetKiller()].perk3.icon;
        perk4.sprite = killers[GetKiller()].perk4.icon;
        lore.text = killers[GetKiller()].Lore;
        perk1Tooltip.header = killers[GetKiller()].perk1.Name;
        perk1Tooltip.content = killers[GetKiller()].perk1.info;
        perk2Tooltip.header = killers[GetKiller()].perk2.Name;
        perk2Tooltip.content = killers[GetKiller()].perk2.info;
        perk3Tooltip.header = killers[GetKiller()].perk3.Name;
        perk3Tooltip.content = killers[GetKiller()].perk3.info;
        perk4Tooltip.header = killers[GetKiller()].perk4.Name;
        perk4Tooltip.content = killers[GetKiller()].perk4.info;
        loreContent.sizeDelta = new Vector2 (loreContent.sizeDelta.x, killers[GetKiller()].scrollHeight);
        title.text = killers[GetKiller()].Name;
    }
    
    public void Button1Pressed()
    {
        perk1.sprite = killers[GetKiller()].perk1.icon;
        perk2.sprite = killers[GetKiller()].perk2.icon;
        perk3.sprite = killers[GetKiller()].perk3.icon;
        perk4.sprite = killers[GetKiller()].perk4.icon;
        perk1Tooltip.header = killers[GetKiller()].perk1.Name;
        perk1Tooltip.content = killers[GetKiller()].perk1.info;
        perk2Tooltip.header = killers[GetKiller()].perk2.Name;
        perk2Tooltip.content = killers[GetKiller()].perk2.info;
        perk3Tooltip.header = killers[GetKiller()].perk3.Name;
        perk3Tooltip.content = killers[GetKiller()].perk3.info;
        perk4Tooltip.header = killers[GetKiller()].perk4.Name;
        perk4Tooltip.content = killers[GetKiller()].perk4.info;
    }
    
    public void Button2Pressed()
    {
        perk1.sprite = killers[GetKiller()].perk5.icon;
        perk2.sprite = killers[GetKiller()].perk6.icon;
        perk3.sprite = killers[GetKiller()].perk7.icon;
        perk4.sprite = killers[GetKiller()].perk8.icon;
        perk1Tooltip.header = killers[GetKiller()].perk5.Name;
        perk1Tooltip.content = killers[GetKiller()].perk5.info;
        perk2Tooltip.header = killers[GetKiller()].perk6.Name;
        perk2Tooltip.content = killers[GetKiller()].perk6.info;
        perk3Tooltip.header = killers[GetKiller()].perk7.Name;
        perk3Tooltip.content = killers[GetKiller()].perk7.info;
        perk4Tooltip.header = killers[GetKiller()].perk8.Name;
        perk4Tooltip.content = killers[GetKiller()].perk8.info;
    }
    
    public void Button3Pressed()
    {
        perk1.sprite = killers[GetKiller()].perk9.icon;
        perk2.sprite = killers[GetKiller()].perk10.icon;
        perk3.sprite = killers[GetKiller()].perk11.icon;
        perk4.sprite = killers[GetKiller()].perk12.icon;
        perk1Tooltip.header = killers[GetKiller()].perk9.Name;
        perk1Tooltip.content = killers[GetKiller()].perk9.info;
        perk2Tooltip.header = killers[GetKiller()].perk10.Name;
        perk2Tooltip.content = killers[GetKiller()].perk10.info;
        perk3Tooltip.header = killers[GetKiller()].perk11.Name;
        perk3Tooltip.content = killers[GetKiller()].perk11.info;
        perk4Tooltip.header = killers[GetKiller()].perk12.Name;
        perk4Tooltip.content = killers[GetKiller()].perk12.info;
    }
    
    public void Button4Pressed()
    {
        perk1.sprite = killers[GetKiller()].perk13.icon;
        perk2.sprite = killers[GetKiller()].perk14.icon;
        perk3.sprite = killers[GetKiller()].perk15.icon;
        perk4.sprite = killers[GetKiller()].perk16.icon;
        perk1Tooltip.header = killers[GetKiller()].perk13.Name;
        perk1Tooltip.content = killers[GetKiller()].perk13.info;
        perk2Tooltip.header = killers[GetKiller()].perk14.Name;
        perk2Tooltip.content = killers[GetKiller()].perk14.info;
        perk3Tooltip.header = killers[GetKiller()].perk15.Name;
        perk3Tooltip.content = killers[GetKiller()].perk15.info;
        perk4Tooltip.header = killers[GetKiller()].perk16.Name;
        perk4Tooltip.content = killers[GetKiller()].perk16.info;
    }

    private int GetKiller()
    {
        int killernum = 0;
        for(var i = 0; i < killers.Length; i++)
        {
            if (_killer == killers[i].Name)
            {
                killernum = i;
                break;
            }
        }
        return killernum;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
