   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:rs12_2011.UI.UIComponentsrs12_2011.UI.UIComponents  5   	   ?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   
   ,    &rs12_2011.UI.UIComponents.NoviKorisnik   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:rs12_2011.UI.UIComponents     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   
     � 
ResizeMode$  NoResize=�5	   	    � Title$ Registracija��5      $	��500��6&   $	��550��63    +� FocusedElement 5
   	   ��  �� ElementName$	 Ime��.��5      � $	��550��6   $	��500��6    � ColumnDefinitions 5   
   �� 5      $	��75* �6   �� 5      $
��475* �6    � RowDefinitions 5   
   �� 5      $	��60* �6   �� 5      $
��440* �6   .+�5   
   � $��0��6   $��1��6   .+�5      �� -   5        $��textBlockHeading��5   3   $
��Left=�6   $��Registracija :��6K   $��Bottom=�6a   $��20(�6|   5      � 5   
   $��1��6   $��1��6   $��	0,0,10,50q�6,   .+�5      � $	��Top=�6   $
��Left=�6+   $	��300��6F   .+�5      �� -   5        $��textBlockIme��5   X   $��16(�6   $
��Left=�6*   $��	35,20,0,0q�6E   $	��Ime��6l   $	��Top=�6w   �� 5      -   5        $��textBlockPrezime��5   X   $��16(�6   $
��Left=�6*   $��	35,52,0,0q�6E   $��Prezime��6p   $	��Top=�6   �� 5      -   5        $��KorisnickoIme��5   X   $��16(�6   $
��Left=�6*   $��	35,80,0,0q�6E   $��Korisnicko Ime��6m   $	��Top=�6�   �� 5      -   5        $��textBlockPassword��5   Y   $��16(�6   $
��Left=�6*   $��
35,107,0,0q�6E   $��Password��6r   $	��Top=�6�   �� 5      -   5        $��textBlockPassword2��5   Y   $��16(�6   $
��Left=�6*   $��
35,136,0,0q�6E   $��Ponovite Password��6s   $	��Top=�6�   �� 5       -   5        $��TipKorisnika��5    Y   $��16(�6   $
��Left=�6*   $��
35,164,0,0q�6E   $��TipKorisnika��6m   $	��Top=�6�   �� 5!      -   5        $	��Ime��5!   I   $
��Left=�6   $��
183,20,0,0q�65   $	��Top=�6i   $	��222��6�   ��6T   �� *Ime+6�   �� 5"      -	   5        $��Prezime��5"   I   $
��Left=�6   $��
183,50,0,0q�65   $	��Top=�6q   $	��222��6�   ��6X   �� *	Prezime+6�   �� 5#      -
   5        $��Korisnicko_ime��5#   I   $
��Left=�6   $��
183,80,0,0q�65   $	��Top=�6~   $	��222��6�   ��6_   �� *KorisnickoIme+6�   G� 5$      -   5        $��passwordBox1��5$   N   $
��Left=�6   $��183,107,0,0q�69   $	��Top=�6b   $	��222��6z   �� 5%      $
��Left=�6i   $��183,164,0,0q�6�   $	��Top=�6�   $	��150��6�   ��6   �� *TipoviKorisnika+ �� SelectedItem 6C   �� *TipKorisnika+6�   G� 5&      -   5         G�Name$ passwordBoxPonovo��5&   N   $
��Left=�6   $��183,136,0,0q�69   $	��Top=�6i   $	��222��6�   �� 5'      -   5        $��tbPoruka��5'      $
��Wrap=�6,   $�� ��6@   
���  ��$��Bottom=�6Y   $��Center=�6t   $	��222��6�   $��112,0,71,70q�6�   �� 5(      -   5         ��Name$ IzlazButton��5(   `   $��Izlaz��6   $��Right=�6)   $��Bottom=�6E   $	��104��6�   �� 5)      -   5        $ btnKorisnik��5)   1   $��Novi Korisnik��6   $��Bottom=�6F   $	��104��6a   6m   5*      5+      5,      5-      