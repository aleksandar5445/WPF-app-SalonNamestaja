   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   	   0    *rs12_2011.UI.UIComponents.NovaAkcijaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ NovaAkcijaWindow��5
   	   $	��550��6"   $	��415��6/    +� FocusedElement 5	   	   ��  �� ElementName$ tbNaziv��.��5      �  � RowDefinitions 5   
   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6   �� 5      $	��150��6   �� 5      $��50��6   �� 5      $��50��6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��18(�6   $��0��6"   $��Naziv��6/   $
��Left=�6<   $��Center=�6W   �� 5   
   -   5        $��tbNaziv��5   /   $��0��6   $��1��6   $��Center=�6U   $
��Left=�6p   $	��150��6�   ��6>   �� *Naziv+6�   �� 5   
   $��18(�6   $��1��6"   $��Datum Pocetka��6/   $
��Left=�6D   $��Center=�6_   (  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��1��6"   $
��Left=�6e   $��Center=�6�      SelectedDate 62   �� *DatumPocetka+ �� Mode$ TwoWay=�6�   �� 5   
   $��18(�6   $��2��6"   $��Datum Kraja��6/   $��Center=�6B   $
��Left=�6]     5   
   $��2��6   $��2��6"   $
��left=�6c   $��Center=�6~    62   �� *
DatumKraja+$ TwoWay=�6~   �� 5    
   $��18(�6   $��3��6"   $��Popusti:��6/   $��Center=�6?   $
��Left=�6Z   &   System.Windows.Controls.DataGrid  5!   
   $��4��6   $��0��6    $��2��60      AutoGenerateColumns .  $	��150��6�   $	��200��6�   $
��Left=�6�   ��6D   �� *	Popusti+	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Sifra��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64      CanUserResize .     CanUserReorder .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Item1+6n     5$      $
 Kolicina��6%   $ * 67    .   .   6A   �� *Item2+6q   5&        5'   
   $��4��6   ��6    �� *	Magacin+�� 5(   
   $��5��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5)      �� $��18(�6   $��0��6&   $��Sifra��63   $
��Left=�6@   $��Center=�6[   �� 5*      $��0��6   $��1��6#   $��Center=�6Q   $
��Left=�6l   $	��150��6�   ��63   �� *SifraPopusta+6�   5+      �� 5,   
   $��5��6   $��1��6"   $ 
Horizontal=�62   .+�5-      �� $��18(�6   $��0��6&   $��Kolicina��63   $
��Left=�6C   $��Center=�6^   �� 5.      $��0��6   $��1��6#   $��Center=�6S   $
��Left=�6n   $	��120��6�   ��63   �� *PopustKolicina+6�   5/      �� 50   
   $��6��6   $��0��6"   $��Bottom=�62   .+�51      �� -   5         ��Name$ DodajPopust��51   <   $��15q�6   $
��Left=�6!   $��DodajPopust��6Q   6g   52      �� 53   
   $ 
Horizontal=�6   $��Bottom=�6.   $��Right=�6I   $��1��6e   $��6��6u   .+�54      �� -   5        $ Ok��54   -   $��10q�6   $��5q�6!   $��OK��69   6F   �� 55      -   5        $ Nazad��55   !   $��10q�6   $��Nazad��60   6@   56      57      58      