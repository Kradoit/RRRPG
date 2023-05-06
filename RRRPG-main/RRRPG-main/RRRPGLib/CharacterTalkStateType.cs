namespace RRRPGLib;

/// <summary>
/// Dialog state for the character
/// </summary>
public enum CharacterTalkStateType {
  /// <summary>
  /// This happens when the game first starts after the 
  /// player presses the "start" button
  /// </summary>
  TALK_SMACK,

  /// <summary>
  /// This happens after the character is hurt by the gun
  /// going off. Change to this state about midway through
  /// the character kill animation
  /// </summary>
  SAY_OW,

  /// <summary>
  /// This happens at the end of the round and the end of the
  /// character kill animation
  /// </summary>
  BONED,

  /// <summary>
  /// This happens immediately after the gun goes off and the
  /// character kill animation begins
  /// </summary>
  GUN_WENT_OFF,

  /// <summary>
  /// This happens if the character pulls the trigger and
  /// the gun does not go off. Currently this also happens
  /// if the gun misfires or the character dodges the bullet.
  /// But I recommend making different states for those cases
  /// so you can put in different animations and dialog for that.
  /// </summary>
  SURVIVED
}
