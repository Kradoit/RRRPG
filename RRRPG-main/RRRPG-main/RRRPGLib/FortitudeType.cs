namespace RRRPGLib;

/// <summary>
/// The mental state of the opponent. This is 
/// currently not used but definitely should
/// be considered as an option for putting into
/// your game
/// </summary>
public enum FortitudeType {
  /// <summary>
  /// Nothing special happens
  /// </summary>
  NORMAL,

  /// <summary>
  /// Opponent forfeits
  /// </summary>
  SCARED,

  /// <summary>
  /// Opponent pulls trigger twice
  /// </summary>
  CRAZY,

  /// <summary>
  /// Opponent pulls trigger three times
  /// </summary>
  SUPER_CRAZY
}
