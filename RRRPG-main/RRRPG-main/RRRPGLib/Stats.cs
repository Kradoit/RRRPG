namespace RRRPGLib;

/// <summary>
/// Used to hold the stats of a character
/// </summary>
public class Stats {
  /// <summary>
  /// Used to determine whether the weapon will
  /// go off or not. A value of 0.5 means the weapon
  /// will go off 50% of the time. A value of 0.8 means
  /// the weapon will go off 20% of the time. Essentially
  /// (1 - Luck) is the chance the weapon will go off. After this,
  /// weapon stats such as misfire rate kick in.
  /// </summary>
  public float Luck { get; set; }

  /// <summary>
  /// Health of the character. All characters start with 100 health.
  /// This is currently not used although weapons do have a damage stat.
  /// </summary>
  public int Health { get; set; }

  /// <summary>
  /// How likely a character is to dodge a weapon going off. Reflex is 
  /// subtracted by weapon's <see cref="Weapon.Velocity"/> to give you
  /// chance of dodging
  /// </summary>
  public float Reflex { get; set; }

  /// <summary>
  /// Explicit constructor
  /// </summary>
  /// <param name="luck">Sets property <see cref="Luck"/></param>
  /// <param name="health">Sets property <see cref="Health"/></param>
  /// <param name="reflex">Sets property <see cref="Reflex"/></param>
  public Stats(float luck, int health, float reflex) {
    Luck = luck;
    Health = health;
    Reflex = reflex;
  }
}
