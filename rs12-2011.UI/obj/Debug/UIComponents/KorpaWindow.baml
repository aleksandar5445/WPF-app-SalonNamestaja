   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:rs12_2011.UI.UIComponentsrs12_2011.UI.UIComponents  5   	   ?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   	   +    %rs12_2011.UI.UIComponents.KorpaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:rs12_2011.UI.UIComponents     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   	     � Title$  KorpaWindow��5
   	   $	��400��6   $	��400��6*   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	KorpaGrid��5   v      AutoGenerateColumns .     CanUserAddRows .     CanUserReorderColumns .     
IsReadOnly . ��6�   �� *Stavke+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Sifra��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   	   CanUserResize	 .  
   CanUserReorder
 .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Item1.Sifra+6t     5      $ Naziv��6%   $ * 64   	 .  
 .   6>   �� *Item1.Naziv+6t     5      $ Jedinicna cena��6%   $ * 6=   	 .  
 .   6G   �� *Item1.JedinicnaCena+6�     5      $ Kolicina��6%   $ * 67   	 .  
 .   6A   �� *Item2+6q   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      � $	��525��6    5      �� 5      $��30 �6$   �� 5      $��30 �6$   �� 5      $��30 �6$   .+�5!      �� $ 
Horizontal=�6   .+�5"      �� -   5        $��tblTotal��5"       $��Total: ��60   �� 5#      -   5        $��tblTotalVrednost��5#       ��68   �� *Total+5$      �� 5%      $��1��6   $ 
Horizontal=�6*   .+�5&      �� -   5        $��tblTotalPopust��5&       $��Total sa popustom: ��66   �� 5'      -   5        $��tblTotalPopustVrednost��5'       ��6>   �� *TotalSaPopustom+5(      �� 5)      $��2��6   $ 
Horizontal=�6*   .+�5*      �� -   5        $��tblGrandTotal��5*       $#��Total sa popustom i porezom: ��65   �� 5+      -   5        $��tblGrandTotalVrednost��5+       ��6=   �� *
GrandTotal+5,      5-      5.      �� 5/   
   $��37��6   $��2��6!   $ 
Horizontal=�6.   $��Right=�6G   $��Bottom=�6c   .+�50      �� -   5        $��btnKupi��50   '   $��0,0,10,5q�6   $
��Kupi��66   6E   �� 51      -	   5        $��btnIzbaciIzKorpe��51   '   $��0,0,35,5q�6   $��Izbaci iz korpe��6?   6Y   �� 52      -
   5        $��Izlaz��52   '   $��0,0,10,5q�6   $��Izlaz��64   6D   53      54      55      