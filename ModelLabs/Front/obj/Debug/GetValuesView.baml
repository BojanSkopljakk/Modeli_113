   M S B A M L   `   `   `  ����@  <Front, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FrontFront  5   	       Front.GetValuesView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Front     5   	     � Title$  GetValuesView��5   	   $	��850��6   $	��400��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��1��6    .��6-   Izaberi GID:6;   �� 5   
   -   5        $��1��5      $��2��6#   ��5      ��  �� Path$
 GIDs� �� SelectedItem 5       �� $ SelectedGid�6l   �� 5!   
   -   5         ��Name$	 sve��5!      $��1��6    $��4��60   $��Izaberi sve��6=   6g   �� 5"   
   -   5         ��Name$ PropListBox��5"      $��1��6'   $��6��67   $	��200��6D   ��. $��Visible=�5$       �� SelectionMode$ Multiple=�5%      ��5"   T   �� $ Props�5&      �� 5'   
   -   5        $��1��5'      $��8��6!   $	��Get��6.   6S   �� 5(   
   $��1��6   $��10��6'   $	��350��65   .��5)      �� -   5         ��Name$	 out��5)      6)   5*      5+      5,      