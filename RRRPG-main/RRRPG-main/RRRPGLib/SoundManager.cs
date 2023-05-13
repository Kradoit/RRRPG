using RRRPGLib;
using System.Drawing.Text;
using System.Media;

namespace RRRPGLib;

/// <summary>
/// Used for playing sound effects but not currently
/// used for playing background music
/// </summary>
public static class SoundManager {
  private static readonly SoundPlayer sndPlayer;

  static SoundManager() {
    sndPlayer = new();
  }

  /// <summary>
  /// Used to play a sound from resource manager
  /// </summary>
  /// <param name="ms">Use <see cref="ResourcesRef.Resources"/> and it's GetStream method to retrieve an audio stream to play</param>
  public static void Play(UnmanagedMemoryStream ms) {
    try {
      sndPlayer.Stream = ms;
      sndPlayer.Play();
    }
    catch {
      // couldn't play sound, oh well
    }
  }
}
