   M S B A M L   `   `   `  ����B  >ArjMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ArjMVVMArjMVVM  5   	   'clr-namespace:ArjMVVM.VM
ArjMVVM.VM  5   	       ArjMVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ArjMVVM     5   	   ,localVMclr-namespace:ArjMVVM.VM     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �� .+�5   
   �� $��5q�69   ��6   �� *Button1ClickCommand+.��6D   
Button 16N   �� 5   
   $��5q�6:   ��6   �� *Button2ClickCommand+.��6E   
Button 26O   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   Clicks Detected (Button1)6/   �� 5      $��Center=�66   ��6   �� *Button1Count+6S   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� .��6   Clicks Detected (Button2)6/   �� 5      $��Center=�66   ��6   �� *Button2Count+6S   5      �� 5   
   .+�5   
   �  � DataContext 6   �� *
testModel1+ � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5!      �� $��Binding to ModelObject1��6   $
��Bold"�66   6J   �� 5"      $��1��6   $��DemiBold"�6%   .��6;   	Property16F   �� 5#      $��2��6   $��DemiBold"�6%   .��6;   	Property26F   �� 5$      $��1��63   $��1��6@   $��Center=�6P   $
��Left=�6k   ��6   �� *	Property1+6k   �� 5%      $��2��67   $��1��6D   $��Center=�6T   ��6   �� *	Property2+6T   5&      � 5'       6   �� *
testModel2+ 5(      �� 5)      �� 5*       5,      �� 5-      �� 5.      �� 5/      .+�51      �� $��Binding to ModelObject1��6   $
��Bold"�6:   6N   �� 52      $��1��6   $��DemiBold"�6%   .��6;   	Property16F   �� 53      $��2��6   $��DemiBold"�6%   .��6;   	Property26F   �� 54      $��1��67   $��1��6D   $��Center=�6T   ��6   �� *	Property1+6T   �� 55      $��2��67   $��1��6D   $��Center=�6T   ��6   �� *	Property2+6T   56      �� 57      $ 
Horizontal=�6   .+�58      �� $��DemiBold"�6   .��6.   'Property1' Bound from MV6J   �� 59      ��6   �� *	Property1+5:      5;      5<      5=      