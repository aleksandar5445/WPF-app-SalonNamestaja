   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   	   2    ,rs12_2011.UI.UIComponents.NoviNamestajWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   	     � Title$  NoviNamestajWindow��5   	   $	��350��6$   $	��350��61   .��5
      �  � RowDefinitions 5   
   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6   �� 5      $��50��6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��18(�6   $��0��6"   $��Naziv��6/   $��Center=�6<   �� 5   
   $��0��6   $��1��6   ��6/   �� *Naziv+�� 5   
   $��18(�6   $��1��6"   $��Sifra��6/   $��Center=�6<   �� 5   
   -   5        $��tbSifra��5      $��1��6!   $��1��6.   ��6>   �� *Sifra+�� 5   
   $��18(�6   $��2��6"   $
��Cena��6/   $��Center=�6;   �� 5   
   $��2��6   $��1��6   ��6/   �� *JedinicnaCena+�� 5   
   $��18(�6   $��3��6"   $��Tip Namestaja��6/   $��Center=�6D   $��Center=�6a   �� 5   
   $��1��6a   $��Center=�6q   $��3��6�   $��Center=�6�   $	��120��6�   ��6   �� *TipoviNamestaja+ �� SelectedItem 6;   �� *TipNamestaja+6�   �� 5   
   $��18(�6   $��4��6"   $��	Kolicina ��6/   $��Center=�6@   �� 5    
   $��4��6   $��1��6   ��6/   �� *KolicinaUMagacinu+�� 5!   
   $��5��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Right=�6O   .+�5"      �  5#      �� 5$      $��50 �6$   �� 5%      .+�5'      �� $ 
Horizontal=�6   .+�5(      �� -   5        $��Ok��5(   5   $��10q�6   $��5q�6)   $��OK��6?   6L   �� 5)      -   5        $��Nazad��5)   )   $��10q�6   $��Nazad��66   6F   5*      5+      5,      5-      5.      