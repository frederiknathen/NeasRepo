   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFUI.ViewsWPFUI.Views  5      &     WPFUI.Views.TilføjNySælgerView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPFUI.Views     5      
�������.��5	      �   � ColumnDefinitions  5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5    
   �� $��1��6   $��6��6!   $��Center=�65   $��16(�6R   $
��Bold"�6`   Tilføj ny sælger6�   �� 5"   
   $	��100��6   $��2��6#   $��1��60   $
��10,0q�6@   $��Center=�6N   	Fornavn6t   �� 5#   
   $	��100��6   $��2��6#   $��2��60   $
��10,0q�6@   $��Center=�6N   	Efternavn6v   �� 5&   
   -   5         ��Name$ Fornavn��5&   >   $	��100��6   $��3��6!   $��1��6.   $
��10,0q�6O   6_   �� 5'   
   -   5        $ 	Efternavn��5'   >   $	��100��6   $��3��6!   $��2��6.   $
��10,0q�6Q   6a   �� 5*   
   $��4��6   $��1��6!   $��
0,10,10,10q�61   $	��100��6E   $��Center=�6T   Vælg Distrikt:6�   �� 5+   
   -   5         ��Name$ Distrikt��5+   0   $��4��6   $��2��6    $	��100��6B    �� DisplayMemberPath$ Distrikt_navn��5-      $��22��65   $	��Top=�6A    �� SelectedIndex$ 0��5.      $
��0,10q�6%    �� SelectedItem 5,      ��  �� Path$ SelectedDistrikt� �� Mode$ OneWayToSource=�5.   5   �� 50   
   -   5        	 ��Name$	 TilføjSælgerTilDB��50      $��5��6,   $��1��69   $��2��6I   .��6^   Tilføj Sælger6m   52      53      