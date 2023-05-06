using System.Windows.Forms;

namespace RRRPGLib;

/// <summary>
/// Used to automatically close open forms so you can have
/// multiple forms in your game and switch among them
/// </summary>
public static class FormManager {
  /// <summary>
  /// List of currently open forms. Add the current
  /// form to this list on Form Load. Remove the current
  /// form from this list on Form Closing.
  /// </summary>
  public static List<Form> openForms;

  static FormManager() {
    openForms = new();
  }

  /// <summary>
  /// Used to close all forms still open. Call this AFTER you
  /// have removed the current form from the openForms list.
  /// Do this when a form calls its Form Closing event. If you
  /// don't call this method after removing the current form, then
  /// you will be stuck in infinite recursion.
  /// </summary>
  public static void CloseAll() {
    for (int i = 0; i < openForms.Count; i++) {
      openForms[i].Close();
    }
  }
}