using System;
using System.Numerics;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Windowing;
using Lumina.Excel.Sheets;

namespace FreeCompanyMemberSearch.Windows;

public class MainWindow : Window, IDisposable
{
    private readonly string goatImagePath;
    private readonly Plugin plugin;

    // We give this window a hidden ID using ##.
    // The user will see "My Amazing Window" as window title,
    // but for ImGui the ID is "My Amazing Window##With a hidden ID"
    public MainWindow(Plugin plugin)
        : base("FC Member Search")
    {

        this.plugin = plugin;
    }

    public void Dispose() { }

    public override void Draw()
    {                
    }
}
