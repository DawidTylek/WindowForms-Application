   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5           WpfApp1.Views.DeatailsView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6#   .+�5      �� $��0��6   $
��Left=�6)   $��5q�6D   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Center=�6!   .+�5      �� $��Center=�6i   $��Center=�6�   $��5q�6�   ��6"   �� *SelectedSchools.Name+ �� FallbackValue$
 NULL�� �� Mode$ TwoWay=�6�   �� 5      $��Center=�6\   $��24(�6y   ��6    �� *SelectedSchools.Name+$	 N/A��6y   5      �� 5      $��IsFavourite��6   5      � 5      $	��125��6   $	��125��6$   .+�5      �� $	��125��6   $	��125��6)   ��65   �� *SelectedSchools.ImagePath+   DefaultListImage# [   �� TargetNullValue# [  �� 5         
MenuButton#��[ 6   
����  �$��Bottom=�6S   $��Right=�6n   
���   �$��DemiBold"�6�   .��6�   Browse5"      5#      5$      �� 5%      $��1��6   $��Bottom=�6)   $ 
Horizontal=�6D   .+�5&      �� #��[ 6   
������$��90��6U   $��40��6`   $��5q�6l   ��5'      �� 5(      $ 
Horizontal=�6%   .+�5)      �� $A��;C:/Users/dawid/Desktop/Window app/Icons/save-171-437037.png��6$   �� 5*      $
��Bold"�6$   .��66   Save6<   5+      5-      5.      5/      �� 51   
   $��1��6   $��5q�6"   .+�52      �� .+�53      ��   DetailBorder#��[ 6   ._�54      �� $
��Bold"�6   ���	#FFF5F7F9$��SchoolPhone��6E   55      �� 56      .+�57      ��   DetailLabel#��[ 6   $
��Home��6A   �� 58        ContentLabel#��[ 6   ��6B   �� *!SelectedSchools.SchoolNumber[0]+$
 NULL���� 5:      #��[ 6   $
��Cell��6A   �� 5;      #��[ 6   ��6B   �� *!SelectedSchools.SchoolNumber[1]+$
 NULL��5<      5=      5>      �� 5?   
   $��2��6   $��5q�6"   .+�5@      �� .+�5A      �� #��[ 6   ._�5B      �� $
��Bold"�6   ���	#FFF5F7F9$��SchoolEmail��6E   5C      �� 5D      .+�5E      �� #��[ 6   $
��Main��6A   �� 5F      #��[ 6   ��6B   �� *!SelectedSchools.PhoneNumbers[0]+$
 NULL���� 5H      #��[ 6   $��Second��6A   �� 5I      #��[ 6   ��6B   �� *!SelectedSchools.PhoneNumbers[1]+$
 NULL��5J      5K      5L      �� 5M   
   $��3��6   $��5q�6"   .+�5N      �� .+�5O      �� #��[ 6   ._�5P      �� $
��Bold"�6   ���	#FFF5F7F9$��Location��6E   5Q      �� 5R      .+�5S      �� #��[ 6   $��
First part��6A   �� 5T      #��[ 6   ��6B   �� *!SelectedSchools.SchoolAdress[0]+$
 NULL���� 5V      #��[ 6   $��Second Part��6A   �� 5W      #��[ 6   ��6B   �� *!SelectedSchools.SchoolAdress[1]+$
 NULL��5X      5Y      5Z      5[      5\      