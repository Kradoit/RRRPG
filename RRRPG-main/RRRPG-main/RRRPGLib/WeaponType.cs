namespace RRRPGLib;

/// <summary>
/// Holds the different weapons you can choose from
/// </summary>
public enum WeaponType {
  /// <summary>
  /// Electrocutes its victim. The wizard carries this
  /// </summary>
  MAGIC_WAND=0,
  
  /// <summary>
  /// Currently unimplemented
  /// </summary>
  NERF_REVOLVER=1,
  
  /// <summary>
  /// Currently unimplemented but there is a Yoshi image
  /// placeholder. Someone please make a gif of Yoshi getting
  /// shot!
  /// </summary>
  BOW=2,
  
  /// <summary>
  /// Currently unimplemented
  /// </summary>
  CORK_GUN=3,
  
  /// <summary>
  /// Sprays freezing cold water on its victim.
  /// The fire goblin carries this.
  /// </summary>
  WATER_GUN=4,
}
public class convertType
{
    public static int convertToInt(WeaponType weapon)
    {
        switch (weapon)
        {
            case WeaponType.MAGIC_WAND: return 0; break;
            case WeaponType.NERF_REVOLVER: return 1; break;
            case WeaponType.BOW: return 2; break;
            case WeaponType.CORK_GUN: return 3; break;
            case WeaponType.WATER_GUN: return 4; break;
            default: return -1; break;
        }
    }
    public static WeaponType convertToWeapon(int weapon)
    {
        switch (weapon)
        {
            case 0:return WeaponType.MAGIC_WAND; break;
            case 1:return WeaponType.NERF_REVOLVER; break;
            case 2:return WeaponType.BOW; break;
            case 3:return WeaponType.CORK_GUN; break;
            case 4:return WeaponType.WATER_GUN; break;
            default: return WeaponType.MAGIC_WAND; break;
        }
    }
}