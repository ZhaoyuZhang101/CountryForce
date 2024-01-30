using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeoModLoader.General;
using NeoModLoader.General.UI.Tab;
using CountryForce.UI.Windows;

namespace CountryForce.UI;

internal static class CountryForceMainTab 
{
    public const string INFO = "info";
    public const string DISPLAY = "display";
    public const string CREATURE = "creature";
    public static PowersTab tab;
    public static void Init()
    {
        tab = TabManager.CreateTab("CountryForceMainTab", "MainTabTitle", "MainTabDescriptionKey",
            SpriteTextureLoader.getSprite("ui/icons/iconsteam"));
        tab.SetLayout(new List<string>
        {
            INFO, DISPLAY, CREATURE
        });
        _createWindows();
        _addButtons();
        tab.UpdateLayout();
    }

    public static void _createWindows()
    {
        //Ԥ�ش���,ǰһ��Ϊ��Ӧ�Ĵ���,��һ��Ϊ���ڱ���
        CountryListWindow.CreateWindow("CountryListWindow", nameof(CountryListWindow));
    }

    public static void _addButtons()
    {
        tab.AddPowerButton(INFO, PowerButtonCreator.CreateWindowButton("CountryList", nameof(CountryListWindow), SpriteTextureLoader.getSprite("ui/icons/iconSteam")));
    }
}