   M S B A M L   `   `   `  ����  Build it    Build_it.View.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Build It��5   	   $	��447��6   $��854.5��6'    � Icon$( "/Build it;component/Asset/icon.png��65   .��5      � .+�5   
   �� $
��Left=�6   $	��116��6,   $��0,-1,0,0q�69   $	��Top=�6K   $	��844��6c   
����·�.+�5      �� $	��100��6    �� Left$ 8��6!   
 �� Top$ 8��61   $	��100��6@   $6��0/Build it;component/Asset/user_outline_72990.png��6L   �� 5      -   5         ��Name$ lblUser��5      $��Username��6%   $	 113��68   $ 32��6J   $��20(�6Z   $��Medium"�6h   $��	quicksand)�6|   �� 5	      -   5        $ lblEmail��5	      $��Email��6&   $	 114��66   $ 57��6H   $��	quicksand)�6X   5
      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvItem��5      dgKamar��$
��auto��6L      AutoGenerateColumns .   �� SelectedIndex$ 0��6v   $��-6,115,-11,0q�6�   ��64   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id Build��6I   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   ��  �� Path$ id_build�6I     5      $		 CPU��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6Q   
 6%   �� $	 CPU�6Q     5      $		 RAM��6D   $	 100 6Q   
 6%   �� $	 RAM�6Q     5      $		 GPU��6D   $	 120 6Q   
 6%   �� $	 GPU�6Q     5      $
	 MOBO��6L   $	 140 6Z   
 6%   �� $ MOTHERBOARD�6Z     5      $		 HDD��6D   $	 100 6Q   
 6%   �� $	 HDD�6Q     5      $	 CASES��6F   $	 100 6U   
 6%   �� $ CASES�6U     5      $	 PRICE��6F   $	 100 6U   
 6%   �� $ HARGA�6U   5      5      5      