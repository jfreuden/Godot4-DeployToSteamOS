#if TOOLS
using Godot;

[Tool]
public partial class Plugin : EditorPlugin
{
	private Control _dock;
	private Control _settingsPanel;
	
	public override void _EnterTree()
	{
		_dock = GD.Load<PackedScene>("res://addons/deploy_to_steamos/deploy_dock/deploy_dock.tscn").Instantiate<Control>();
		_settingsPanel = GD.Load<PackedScene>("res://addons/deploy_to_steamos/settings_panel/settings_panel.tscn").Instantiate<Control>();
		
		AddControlToContainer(CustomControlContainer.Toolbar, _dock);
		AddControlToContainer(CustomControlContainer.ProjectSettingTabRight, _settingsPanel);
	}

	public override void _ExitTree()
	{
		RemoveControlFromContainer(CustomControlContainer.Toolbar, _dock);
		RemoveControlFromContainer(CustomControlContainer.ProjectSettingTabRight, _settingsPanel);
		
		_dock.Free();
	}
}
#endif
