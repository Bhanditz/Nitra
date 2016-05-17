using System;
using Nitra.ClientServer.Messages;
using ReactiveUI;
using Nitra.ViewModels;

namespace Nitra.Visualizer.ViewModels
{
  public class PopupItemViewModel : ReactiveObject
  {
    public int                        SymbolId     { get; private set; }
    public TestVm                     File         { get; private set; }
    public NSpan                      Span         { get; private set; }
    public bool                       IsDefenition { get; private set; }
    public IntelliSensePopupViewModel Popup        { get; private set; }
    public string                     Text         { get; private set; }

    public PopupItemViewModel(int symbolId, TestVm file, NSpan span, bool isDefenition, IntelliSensePopupViewModel popup)
    {
      SymbolId     = symbolId;
      File         = file;
      Span         = span;
      IsDefenition = isDefenition;
      Text         = file.Name + " (" + span + ")"; // TODO: convert to line pos and meke line preview
      Popup        = popup;
    }
  }
}