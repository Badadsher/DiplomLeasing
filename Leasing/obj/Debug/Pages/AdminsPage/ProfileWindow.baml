   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Leasing.Pages.AdminsPageLeasing.Pages.AdminsPage  5   	   ,    &Leasing.Pages.AdminsPage.ProfileWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Leasing.Pages.AdminsPage     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  ProfileWindow��5	   	   {�. $	��307��60   $	��595��6=    � 
ResizeMode$ NoResize=�6`    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�   
������ .��5
      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   .��5      � $��	0,0,0,-21q�6   .+�5      �� -   5         ��Name$ CloseButton��5       &  "MaterialDesignFloatingActionButton#��[  5      $
��Left=�5      
���   �$��509,8,0,244q�5       � Cursor$
 Hand��5      ��5      Z� ��5      Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
���   �$��39��6N   $��39��6Z   $��Center=�6e   5      � 5      $
��Left=�6   $��	38,81,0,0q�62   $	��Top=�6E   .+�5      �� -   5        	 ��Name$	 myImage��5      $	��200��6-   $	��150��69   $��UniformToFill=�6F   5      �� 5      -   5        
 ��Name$
 	nameLabel��5      $��Имя:��6+   $��Center=�6:   $��0,64,0,0q�6W   $	��Top=�6i   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $��55��6�   �� 5      -   5        $
 surnameLabel��5      $��Фамилия:��6.   $
��Left=�6A   $��262,111,0,0q�6\   $	��Top=�6q   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��106��6�   �� 5      -   5        $
 patronymicLabel��5      $��Отчество:��61   $
��Left=�6E   $��262,162,0,0q�6`   $	��Top=�6u   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��303��6�   �� 5      -   5        $
 numberLabel��5      $��Номер:��6-   $
��Left=�6>   $��262,210,0,0q�6Y   $	��Top=�6n   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $��79��6�   �� 5       -   5        $
 nameLabelBox��5       $��Имя:��6.   $
��Left=�6=   $��
310,65,0,0q�6X   $	��Top=�6l   ���	#E5757575$��18(�6�   $��Bahnschrift)�6�   $��47��6�   $	��252��6�   �� 5!      -	   5        $
 surnameLabelBox��5!      $��Имя:��61   $
��Left=�6@   $��363,111,0,0q�6[   $	��Top=�6p   ���	#E5757575$��18(�6�   $��Bahnschrift)�6�   $��47��6�   $	��213��6�   �� 5"      -
   5        $
 patronymicLabelBox��5"      $��Имя:��64   $
��Left=�6C   $��363,163,0,0q�6^   $	��Top=�6s   ���	#E5757575$��18(�6�   $��Bahnschrift)�6�   $��47��6�   $	��213��6�   �� 5#      -   5        $
 numberLabelBox��5#      $��Имя:��60   $
��Left=�6?   $��337,211,0,0q�6Z   $	��Top=�6o   ���	#E5757575$��18(�6�   $��Bahnschrift)�6�   $��47��6�   $	��234��6�   5$      5%      5&      5'      