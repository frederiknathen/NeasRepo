   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFUI.ViewsWPFUI.Views  5           WPFUI.Views.DistrikterView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPFUI.Views     5      
�������.��5	      �   � ColumnDefinitions  5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5       $��20 �6   .+�5#   
   �� $��1��6   $��1��6!   $��
0,10,10,10q�61   $	��100��6E   Vælg Distrikt:6e   �� 5$   
   -   5         ��Name$ Distrikt��5$   0   $��1��6   $��2��6    $	��100��6B    �� DisplayMemberPath$ Distrikt_navn��5&      $��22��65   $	��Top=�6A    �� SelectedIndex$ 0��5'      $
��0,10q�6%    �� SelectedItem 5%      ��  �� Path$ SelectedDistrikt� �� Mode$ OneWayToSource=�5'   5   �� 5)   
   $��2��6   $��7��6!   $��0,0,0,27q�65   �� 5*   
   $��2��6   $��1��6!   $	��5,0q�61   $��Center=�6>   Ansvarlig Sælger:6n   �� 5+   
   $��2��6   $��2��6!   $	��5,0q�61   $��Center=�6>   
Sælgere6e   �� 5,   
   $��2��6   $��3��6!   $��Center=�61   Tildel sælgere6^   �� 5/   
   -   5         ��Name$ AnsvarligSælgerNavn��5/   1   $��3��6   $��1��6!   $��	Underline{�6N   
���  ��6j   �� 50   
   -   5        	 ��Name$	 SekundæreSælgere��50   0   $��3��6   $��2��6    $ 	FuldeNavn��51      $	��5,0q�61    52      �� $ SelectedSælger�$ OneWayToSource=��� 53   
   -   5        $ IndsætDistrikt��53   0   $��3��6   $��3��6    $	��100��6H   $ Distrikt_navn��55      $��22��65   $	��Top=�6A   $ 0��56      $
��0,10q�6%    54      �� $ SelectedIndsætDistrikt�$ OneWayToSource=�56   5   �� 58   
   -   5        
 ��Name$
 GørMarkeretAnsvarlig��58      $��5��6/   $��1��6<   $	��5,0q�6L   .��6Z   Gør sælger ansvarlig6p   �� 59   
   -   5        $
 FjernMarkeretSomSekundær��59      $��5��63   $��2��6@   $	��5,0q�6P   .��6^   Fjern som sekundær6r   �� 5:   
   -   5        $*
 $SætSælgerSomSekunderIAndetDistrikt��5:      $��5��6=   $��3��6J   $	��5,0q�6Z   .��6g   (&Tilføj som sekundær i andet distrikt6�   �� 5=   
   $��6��6   $��7��6!   $��0,10,0,0q�65   �� 5?   
   $��7��6   $��1��6!   $	��5,0q�61   $
��Wrap=�6>   $	��100��6R   $��Center=�6a   
Butikker6�   �� 5A   
   -   5        $	 DistriktsButikker��5A   0   $��8��6   $��1��6    $ 
Butik_navn��5B      $��1��61   $��	5,10,82,1q�6E   $��2��6X   5E      5F      