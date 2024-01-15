using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp3.Commands
{
    public class MaximizeCommand : ICommand
    {
        private readonly Button _button;
        private readonly double _originalFontSize;
        private readonly double _modifyFontSize;
        private readonly Thickness _originalPadding;
        private readonly Thickness _modifyThickness;

        public MaximizeCommand(Button button,double modifyFontSize, Thickness modifyThickness)
        {
            _button = button;
            _originalFontSize = _button.FontSize;
            _originalPadding = _button.Padding;
            _modifyThickness = modifyThickness;
            _modifyFontSize = modifyFontSize;
            
        }

        public void Execute()
        {
            _button.FontSize = _modifyFontSize;
            _button.Padding = _modifyThickness;
        }

        public void Undo()
        {
            _button.FontSize = _originalFontSize;
            _button.Padding = _originalPadding;
        }
    }
    public class UndoMaximizeCommand : ICommand
    {
        private readonly Button _button;
        private readonly double _originalFontSize;
        private readonly Thickness _originalPadding;

        public UndoMaximizeCommand(Button button, double originalFontSize, Thickness originalPadding)
        {
            _button = button;
            _originalFontSize = originalFontSize;
            _originalPadding = originalPadding;
        }

        public void Execute()
        {
            //_button.FontSize = 12;
            //_button.Padding = new Thickness(1,1, 1, 1);
            _button.FontSize = _originalFontSize;
            _button.Padding = _originalPadding;
        }

        public void Undo()
        {
            _button.FontSize = _originalFontSize;
            _button.Padding = _originalPadding;
        }
    }

}
