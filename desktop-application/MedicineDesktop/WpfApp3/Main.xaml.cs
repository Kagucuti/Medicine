
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using WpfApp3.Commands;
using WpfApp3.Pages;

namespace WpfApp3
{
    public partial class Main : Window
    {
        public Main()
        {

            InitializeComponent();
            buttonsPanel = [MyCabButton, ExitButton, MinimazeButton, MaximizeButton];
            buttonsMenu = [MedicineButton, UsersButton, SearchButton, InstrumentsButton];
            StateChanged += Main_StateChanged;
        }
        private bool isFirstClick = true;
       
        private Thickness originalPadding;
        private double originalFontSize;
        private double originalWidth;
        private double originalHeight;
        private double originalFont;
        private bool sizeSlide = false;
        private readonly CommandInvoker _commandInvoker = new CommandInvoker();
        List<Button> buttonsPanel;
        List<Button> buttonsMenu;
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Maximize_Button(object sender, RoutedEventArgs e)
        {
           
            CopySettings();
            if (WindowState != WindowState.Maximized)
            {
            
                SetMaximaze(buttonsPanel, 15, new Thickness(16, 12, 16, 12));
                SetSizes(buttonsMenu, 15, 50, 230);
                WindowSetProps(280, WindowState.Maximized);
                TopRow.Height = 45;

            }
            else
            {
                SetMinimaze(buttonsPanel,originalFontSize,originalPadding);
                SetSizes(buttonsMenu, originalFont, originalHeight, originalWidth);
                WindowSetProps(150, WindowState.Normal);

                TopRow.ClearValue(HeightProperty);
            }

        }
        private void SetMaximaze(List<Button> bts,double newFontSize, Thickness newThickness)
        {
            foreach (Button b in bts)
                SetCommandAndExecute(new MaximizeCommand(b, newFontSize, newThickness));
        }
        private void SetMinimaze(List<Button> bts, double oldFontSize, Thickness oldThickness)
        {
            foreach (Button b in bts)
                SetCommandAndExecute(new UndoMaximizeCommand(b, oldFontSize, oldThickness));
        }
        private bool clickMargin;
        private void SetSizes(List<Button> bts, double f, double h, double w)
        {
            foreach (Button b in bts)
            {
                b.Padding = originalPadding;
                b.FontSize = f;
                b.Height = h;
                b.Width = w;
            }
        }
        private void WindowSetProps(int width, WindowState ws)
        {
            LeftColumn.Width = width;
            WindowState = ws;
        }

        private bool slide;
        private void SlideLeftColumn(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();

            if (slide is true)
            {
                animation.To = (sizeSlide is false) ?0:0;
            }
            else
            {
                animation.To = -365;
            }
            slide = !slide;
            animation.Duration = TimeSpan.FromSeconds(0.6);

            ThicknessAnimation marginAnimation = new ThicknessAnimation
            {
                To = new Thickness((double)animation.To, 0, 0, 0),
                Duration = TimeSpan.FromSeconds(0.6)
            };

            LeftColumn.BeginAnimation(MarginProperty, marginAnimation);
        }

        private void CopySettings()
        {
            if (isFirstClick)
            {
                originalFont = UsersButton.FontSize;
                originalHeight = UsersButton.Height;
                originalWidth = UsersButton.Width;
                originalFontSize = MyCabButton.FontSize;
                originalPadding = MyCabButton.Padding;
                isFirstClick = false;
            }
        }
        private void SetCommandAndExecute(Commands.ICommand command)
        {
            _commandInvoker.SetCommand(command);
            _commandInvoker.ExecuteCommand();
        }

        private void Minimize_Button(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private Point startPoint;

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(this);
        }

        private async void Window_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var currentPoint = e.GetPosition(this);

                if (Math.Abs(currentPoint.X - startPoint.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(currentPoint.Y - startPoint.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    if (Mouse.DirectlyOver is Button)
                    {
                        return;
                    }

                    DragMove();
                }
            }
           
        }
        private void Main_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                SetMinimaze(buttonsPanel, originalFontSize, originalPadding);
                SetSizes(buttonsMenu, originalFont, originalHeight, originalWidth);
            }
        }

        private void MyCab(object sender, RoutedEventArgs e)
        {

        }

        private void Window_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void ClearFrameContent()
        {
            Сontent.Content = null;
            while (Сontent.NavigationService.CanGoBack)
                Сontent.NavigationService.RemoveBackEntry();
        }
        private void MedicineButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFrameContent();
            Medicines medicines = new Medicines();
           
            Сontent.Navigate(medicines);
        }

        private void UsersButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFrameContent();
            Users users = new Users();
         
            Сontent.Navigate(users);
        }

        private void InstrumentsButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFrameContent();
            Instruments instruments = new Instruments();
            Сontent.Navigate(instruments);
        }
    }


}
