   M S B A M L   `   `   `  ����B  >DemoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DemoAppDemoApp  5   	   G CChartSurface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:ChartSurface;assembly=ChartSurfaceChartSurface 5   	       DemoApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DemoApp     5   	   ?l10clr-namespace:ChartSurface;assembly=ChartSurface     5   	   .��5
      � $��10q�6   $
��Left=�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � -   5         �Name$ FGrid��5      $��0��6   $	��550��6+   $
��Left=�67   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'     5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��0,0,0,2q�6   $��FontSize��6-   $��0��6=   $��0��6M   �� 5       $��0,0,0,2q�6m   $��1��6~   $��0��6�   ��6   ��  �� Path$ FontSizeItems� �� SelectedItem 6F   �� $ FontSize�5"      �� 5#      $��0,0,0,2q�6   $��
Line Brush��6-   $��2��6?   $��0��6O   �� 5$      $��0,0,0,2q�6   $��3��6,   $��0��6<    �� SelectedIndex 6I   �� $ 	LineBrush�.@�5%      �� 
���  ��          6o   �� 5&      
��� � �          6q   �� 5'      
����  �          6p   5(      �� 5)      $��0,0,0,2q�6   $��
XAxisTitle��6-   $��4��6?   $��0��6O   �� 5*      $��0,0,0,2q�6   $��0��6+   $��5��68   ��6H   �� *
XAxisTitle+ �� UpdateSourceTrigger$ PropertyChanged=��� 5,      $��
FontFamily��6   $��0��6.   $��1��6>   �� 5-      $��1��6q   $��1��6�   ��6   �� $ FontFamilyItems� 6H   �� $ 
FontFamily�5/      �� 50      $��LineThickness��6   $��2��61   $��1��6A   �� 51      $��3��6r   $��1��6�   ��6   �� $ LineThicknessItems� 6K   �� *LineThickness+53      �� 54      $��YAxis Title��6   $��4��6/   $��1��6?   �� 55      $��1��6   $��5��6'   ��67   �� *
YAxisTitle+$ PropertyChanged=�56      57      � 58   
   -   5        $ RBGrid��58      $��1��6   $	��550��6.   $
��Left=�6:    59      �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   .+�5>      �� $��	Line Data��6   $��0��6)   	� 5?      $��1��6    d� 	IsChecked$
 TrueY�6*   .��6;   
Sinewave6E   	� 5@      $��2��6    6*   �� *	ChartType+.��6J   Square wave6W   5A      � 5B   
   $��2��6   .+�5C        ChartSurface.ChartSurface  -   5          Name$ CS��5C      6,   5D      5E      5F      