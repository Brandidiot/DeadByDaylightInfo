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
    [SerializeField] private TextMeshProUGUI info;
    [SerializeField] private TextMeshProUGUI lore;
    [SerializeField] private GameObject killerList;
    [SerializeField] private GameObject killerPanel;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject backToMainButton;
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
    [SerializeField] private RectTransform infoContent;
    
    private bool _back = false;
    private bool _backToMain = false;
    private KillerProfile _killerProfile = null;

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
        else backButton.SetActive(true);
        
        if (_backToMain == false)
        {
            backToMainButton.SetActive(false);
        }
        else backToMainButton.SetActive(true);;
    }

    public void Back()
    {
        title.text = "Select Killer";

        _back = false;
        _backToMain = true;
    }

    public void KillerBuilds()
    {
        title.text = "Select Killer";
        _backToMain = true;
    }
    
    public void BackToMain()
    {
        title.text = "";
        _backToMain = false;
    }
    
    public void KillerSelected()
    {
        InitiateKiller(EventSystem.current.currentSelectedGameObject.name);
    }
    
    private void InitiateKiller(string killer)
    {
        _back = true;
        _backToMain = false;
        _killerProfile = killers[GetKiller(killer)];
        backButton.SetActive(true);

        if (_killerProfile.build1Name != "")
        {
            button1.gameObject.SetActive(true);
            button1Text.text = _killerProfile.build1Name;
        }
        else
        {
            button1.gameObject.SetActive(false);
        }

        if (_killerProfile.build2Name != "")
        {
            button2.gameObject.SetActive(true);
            button2Text.text = _killerProfile.build2Name;
        }
        else
        {
            button2.gameObject.SetActive(false);
        }
        
        if (_killerProfile.build3Name != "")
        {
            button3.gameObject.SetActive(true);
            button3Text.text = _killerProfile.build3Name;
        }
        else
        {
            button3.gameObject.SetActive(false);
        }
        
        if (_killerProfile.build4Name != "")
        {
            button4.gameObject.SetActive(true);
            button4Text.text = _killerProfile.build4Name;
        }
        else
        {
            button4.gameObject.SetActive(false);
        }

        killerPortrait.sprite = _killerProfile.Icon;
        perk1.sprite = _killerProfile.perk1.icon;
        perk2.sprite = _killerProfile.perk2.icon;
        perk3.sprite = _killerProfile.perk3.icon;
        perk4.sprite = _killerProfile.perk4.icon;
        info.text = _killerProfile.info;
        lore.text = _killerProfile.Lore;
        perk1Tooltip.header = _killerProfile.perk1.Name;
        perk1Tooltip.content = _killerProfile.perk1.info;
        perk2Tooltip.header = _killerProfile.perk2.Name;
        perk2Tooltip.content = _killerProfile.perk2.info;
        perk3Tooltip.header = _killerProfile.perk3.Name;
        perk3Tooltip.content = _killerProfile.perk3.info;
        perk4Tooltip.header = _killerProfile.perk4.Name;
        perk4Tooltip.content = _killerProfile.perk4.info;
        loreContent.sizeDelta = new Vector2 (loreContent.sizeDelta.x, _killerProfile.scrollHeight);
        infoContent.sizeDelta = new Vector2 (infoContent.sizeDelta.x, _killerProfile.infoHeight);
        title.text = _killerProfile.Name;
    }
    
    public void Button1Pressed()
    {
        perk1.sprite = _killerProfile.perk1.icon;
        perk2.sprite = _killerProfile.perk2.icon;
        perk3.sprite = _killerProfile.perk3.icon;
        perk4.sprite = _killerProfile.perk4.icon;
        perk1Tooltip.header = _killerProfile.perk1.Name;
        perk1Tooltip.content = _killerProfile.perk1.info;
        perk2Tooltip.header = _killerProfile.perk2.Name;
        perk2Tooltip.content = _killerProfile.perk2.info;
        perk3Tooltip.header = _killerProfile.perk3.Name;
        perk3Tooltip.content = _killerProfile.perk3.info;
        perk4Tooltip.header = _killerProfile.perk4.Name;
        perk4Tooltip.content = _killerProfile.perk4.info;
    }
    
    public void Button2Pressed()
    {
        perk1.sprite = _killerProfile.perk5.icon;
        perk2.sprite = _killerProfile.perk6.icon;
        perk3.sprite = _killerProfile.perk7.icon;
        perk4.sprite = _killerProfile.perk8.icon;
        perk1Tooltip.header = _killerProfile.perk5.Name;
        perk1Tooltip.content = _killerProfile.perk5.info;
        perk2Tooltip.header = _killerProfile.perk6.Name;
        perk2Tooltip.content = _killerProfile.perk6.info;
        perk3Tooltip.header = _killerProfile.perk7.Name;
        perk3Tooltip.content = _killerProfile.perk7.info;
        perk4Tooltip.header = _killerProfile.perk8.Name;
        perk4Tooltip.content = _killerProfile.perk8.info;
    }
    
    public void Button3Pressed()
    {
        perk1.sprite = _killerProfile.perk9.icon;
        perk2.sprite = _killerProfile.perk10.icon;
        perk3.sprite = _killerProfile.perk11.icon;
        perk4.sprite = _killerProfile.perk12.icon;
        perk1Tooltip.header = _killerProfile.perk9.Name;
        perk1Tooltip.content = _killerProfile.perk9.info;
        perk2Tooltip.header = _killerProfile.perk10.Name;
        perk2Tooltip.content = _killerProfile.perk10.info;
        perk3Tooltip.header = _killerProfile.perk11.Name;
        perk3Tooltip.content = _killerProfile.perk11.info;
        perk4Tooltip.header = _killerProfile.perk12.Name;
        perk4Tooltip.content = _killerProfile.perk12.info;
    }
    
    public void Button4Pressed()
    {
        perk1.sprite = _killerProfile.perk13.icon;
        perk2.sprite = _killerProfile.perk14.icon;
        perk3.sprite = _killerProfile.perk15.icon;
        perk4.sprite = _killerProfile.perk16.icon;
        perk1Tooltip.header = _killerProfile.perk13.Name;
        perk1Tooltip.content = _killerProfile.perk13.info;
        perk2Tooltip.header = _killerProfile.perk14.Name;
        perk2Tooltip.content = _killerProfile.perk14.info;
        perk3Tooltip.header = _killerProfile.perk15.Name;
        perk3Tooltip.content = _killerProfile.perk15.info;
        perk4Tooltip.header = _killerProfile.perk16.Name;
        perk4Tooltip.content = _killerProfile.perk16.info;
    }

    private int GetKiller(string killer)
    {
        var killernum = 0;
        for(var i = 0; i < killers.Length; i++)
        {
            if (killer != killers[i].Name) continue;
            killernum = i;
            break;
        }
        return killernum;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
