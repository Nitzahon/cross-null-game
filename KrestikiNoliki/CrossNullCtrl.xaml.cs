using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikiNoliki
{
  /// <summary>
  /// Interaction logic for CrossNull.xaml
  /// </summary>
  public partial class CrossNullCtrl : UserControl
  {
    public CrossNull Value
    {
      get { return (CrossNull)GetValue(ValueProperty); }
      set { SetValue(ValueProperty, value); }
    }
    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(CrossNull), typeof(CrossNullCtrl), new UIPropertyMetadata(CrossNull.Empty));

    protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
    {
      if (e.ClickCount > 0 && Value == CrossNull.Empty)
      {
        Value = CrossNull.Cross;
      }
      base.OnMouseRightButtonUp(e);
    }
    
    public CrossNullCtrl()
    {
      InitializeComponent();
    }
  }
}
