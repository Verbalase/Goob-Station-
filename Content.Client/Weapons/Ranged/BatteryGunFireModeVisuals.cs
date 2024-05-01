using Content.Client.Weapons.Ranged.Systems;
using Content.Shared.Weapons.Ranged.Systems;
using Content.Client.Weapons.Ranged.Components;

namespace Content.Client.Weapons.Ranged;

/// <summary>
/// Visualizer for gun mag presence; can change states based on ammo count or toggle visibility entirely.
/// </summary>
public sealed partial class BatteryGunFireModeVisuals : EntitySystem

{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<BatteryWeaponFireModesSystem, FireModeSetEvent>(OnFireModeSet);
    }

    public void OnFireModeSet(ref FireModeSetEvent ev)
    {
        MagazineVisualsComponent.MagState = ev.ModeMagSprite;
    }
}