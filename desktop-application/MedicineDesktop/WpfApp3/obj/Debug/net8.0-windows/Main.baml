   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.Main   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   -   5          � 
ResizeMode$  	CanResize=�5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � UseLayoutRounding$
 True��5   	   $	��450��5   	   $	��800��5   	   ��5      �� 5   
    �� 
TargetType" �6   .�5      -   5        5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ]� -   5         ]�Name$ TopRow��5   E   $��False��6   ���	#FFB7B7B7$��Stretch=�6U   .+�5      �� $��Right=�6    �� Orientation$ 
Horizontal=�64   $	��Top=�6M   $��10,0,0,0q�6e   .+�5      �� -   5        .��5   5   menu6;   �� 5      -   5         ��Name$ MyCabButton��5   +   $��	10,5,10,5q�6@   .��6T   #!Особистий кабінет6g   �� 5       -   5        $ MinimazeButton��5       $��	10,5,10,5q�6M   .��6a   -6d   �� 5!      -   5        $ MaximizeButton��5!      $��	10,5,10,5q�6M   .��6a   □6d   �� 5"      -   5        $ 
ExitButton��5"      $��	10,5,10,5q�6E   .��6Y   x6\   5#      5$      5&      � 5'   
   $��1��6   
�������	 � ColumnDefinitions	 5)      �� 5*      -	   5        
 ��Name$
 leftColumnDefinition��5*   0   $
��Auto �6#   60   �� 5+      $��* �6#   .+�5-      � -
   5         �Name$ 
LeftColumn��5-   5   $��0��6   
�������$	��160��6I    K� ZIndex$ 1��6U   .+�5.      �� $��Center=�6   $��Center=�6:   .+�5/      �� -   5        $ MedicineButton��5/   U   $��Center=�6   $��Center=�68   $��	10,2,10,3q�6m   $	��160��6�   $��27��6�   .��6�   
Ліки6�   �� 50      -   5        $ UsersButton��50   U   $��Center=�6   $��Center=�68   $��	10,2,10,3q�6j   $	��160��6}   $��27��6�   .��6�   Користувачі6�   �� 51      -   5        $ InstrumentsButton��51   U   $��Center=�6   $��Center=�68   $��	10,2,10,3q�6p   $	��160��6�   $��27��6�   .��6�   Інструменти6�   �� 52      -   5        $ SearchButton��52   U   $��Center=�6   $��Center=�68   $��	10,2,10,3q�6k   $	��160��6~   $��27��6�   .��6�   
Пошук6�   53      55      � 56      -   5        $ MainContent��56      $��1��6(   
�������.+�58       � -   5          �Name$ Сontent��58        � NavigationUIVisibility$ Hidden=�6)   6K   59      5;      5<       �� EdgeMode$ Aliased=�5=   =    �� BitmapScalingMode$ HighQuality=�5>   S   5?      