using NeoModLoader.General.UI.Window;
using NeoModLoader.General;
using NeoModLoader.General.UI.Window.Utils.Extensions;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace CountryForce.UI.Windows;
public class CountryListWindow: AutoLayoutWindow<CountryListWindow>
{
    private UiUnitAvatarElement unit_avatar;
    private void Update()
    {
        if (!Initialized||!IsOpened) return;
    }
    protected override void Init()
    {
        GetLayoutGroup().spacing = 3;
    }
}
