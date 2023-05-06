namespace RRRPGLib;

/// <summary>
/// This contains the current state of the character for displaying images
/// </summary>
public enum CharacterImgStateType {
  /// <summary>
  /// Character is not doing anything (for opponent, this is the image of them with a weapon)
  /// </summary>
  IDLE,

  /// <summary>
  /// Character is not holding a weapon (this is after Bender has grabbed it)
  /// </summary>
  NO_WEAPON,

  /// <summary>
  /// Character is ready to pull the trigger
  /// </summary>
  READY,

  /// <summary>
  /// Character was unlucky
  /// </summary>
  KILL
}
