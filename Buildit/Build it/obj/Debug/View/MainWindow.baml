   M S B A M L   `   `   `  ����  Build it    Build_it.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  Build It��5   	   $	��640��6   $
��1024��6'    � Icon$( "/Build it;component/Asset/icon.png��64    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5	      �� .��5
      W�  �� TargetProperty$ Opacity�6&    W� From$ 0X�6K   	 W� To$ 1X�6T    g� Duration$ 0:0:0.5D�6[    g� FillBehavior$ HoldEnd=�6n   5      5      5      .��5      � .+�5   
   �� $��-6,0,6,0q�6   .+�5      �� -   5        	 ��Name$	 Header��5      $	��120��6%   
 �� Left$
 6��62   $
��1016��6B   
����·�.+�5      �� $��72��6   $	��Top=�6$   $	��232��6<   $��..\Asset\logo.png��6H    J� RenderTransformOrigin$ 0.507,0.615&�6c   $
 2��6�   
 �� Top$ 26��6�   �� 5      -   5         ��Name$ btnComponent��5      $��	Component��6/   $��	Quicksand)�6C   
����·�$��0q�6o   $��16(�6�   $��25��6�   $	
 435��6�   $ 95��6�   $	��118��6�   �� 5      -   5        $ 
btnCompare��5      $��Compare��6-   $��	Quicksand)�6?   
����·�$��0q�6k   $��16(�6�   $��25��6�   $	
 554��6�   $ 95��6�   $	��103��6�   �� 5      -   5        $ btnBuild��5      $��Build��6+   $��	Quicksand)�6;   
����·�$��0q�6g   $��16(�6�   $��25��6�   $	
 349��6�   $ 95��6�   $��85��6�   �� 5      -   5        $ btnBuildMode��5      $��
Build Mode��6/   $	��106��6D   $��	Quicksand)�6P   ���	#FF3EC996$��0q�6~   $��16(�6�   $��35��6�   $	
 519��6�   
�������6�   �� 5      -   5        $ btnItemPage��5      $��	Item Mode��6.   $	��111��6B   $��	Quicksand)�6N   ���	#FF004B6A$��0q�6|   $��16(�6�   $��35��6�   $	
 408��6�   
�������6�   5      �� 5      -   5         ��Name$ lblUsername��5      $��Label��6)   $��Roboto)�69   $��16(�6M   $��38��6[   $	
 924��6g   $ 38��6y   $��76��6�   �� 5      -   5         ��Name$ 	UserImage��5      $6��0/Build it;component/Asset/user_outline_72990.png��6C    � Cursor$
 Hand��6}   $��74��6�   $	
 835��6�   $ 25��6�   $��82��6�   ]� 5      $	��489��6   ��.  $
 8��6;   $	 120��6K   $
��1014��6\   .+�5       � -	   5          �Name$ frmMain��5        � NavigationUIVisibility$ Hidden=�6)     � Source$ BuildPage.xaml?�6I   $
��1013��6a   5      5"      �� 5#   
   -
   5        $ 	btnLogout��5#      $��Logout��6$   ���	#FF004B6A$��0q�6L   
�������$��	quicksand)�6�   $��1,0,1,1q�6�   $��914,70,43,511q�6�   5$      5%      