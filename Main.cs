using System;
using System.IO;
using UnityEngine;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using NeoModLoader.services;
using CountryForce.UI;
namespace CountryForce;

//继承自Basic Mod(必要)
public class Main : BasicMod<Main>, IReloadable, IUnloadable
{
    internal static bool _reload_switch;
    internal static Transform prefab_library;
    [Hotfixable]
    public void Reload()
    {

    }
    // Mod启用时被调用;
    // be called when mod is loaded;
    protected override void OnModLoad()
    {
        LogInfo("欢迎使用CountryForce模组");
        CountryForceMainTab.Init();

    }
    //mod 卸载调用;
    public void OnUnload()
    {
    }
}