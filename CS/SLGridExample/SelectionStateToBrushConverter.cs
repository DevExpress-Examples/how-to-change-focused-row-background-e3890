using System;
using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Windows.Media;

namespace SLGridExample {
    public class SelectionStateToBrushConverter :IValueConverter {

        public SolidColorBrush NormalBrush { get; set; }
        public SolidColorBrush FocusedBrush { get; set; }
        public SolidColorBrush SelectedBrush { get; set; }
        public SolidColorBrush FocusedAndSelectedBrush { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            SelectionState state = (SelectionState)value;

            if (state == SelectionState.Focused) {
                return FocusedBrush;
            }

            if (state == SelectionState.Selected) {
                return SelectedBrush;
            }

            if (state == SelectionState.FocusedAndSelected) {
                return FocusedAndSelectedBrush != null ? FocusedAndSelectedBrush : FocusedBrush;
            }

            return NormalBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
