   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Leasing.Pages.AdminsPageLeasing.Pages.AdminsPage  5   	   &     Leasing.Pages.AdminsPage.AddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Leasing.Pages.AdminsPage     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  AddUser��5	   	    � 
ResizeMode$ NoResize=�6   $	��700��60   $	��500��6=    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6c    � WindowStyle$
 None=�6�   
������ .��5
      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   .��5      � $��	0,0,0,-21q�6   .+�5      �� -   5         ��Name$ CloseButton��5   �    &  "MaterialDesignFloatingActionButton#��[  6   $
��Left=�6U   
���   �$��424,2,0,643q�6�    � Cursor$
 Hand��6�   ��6p   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
���   �$��40��6N   $��38��6Z   $��Center=�6e   5      �� 5      -   5        	 ��Name$	 TxbName��5      $��Center=�6+    ! MaterialDesignOutlinedTextBox#��[ 6Q   $��Center=�6�   $��0,41,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5      $��Имя��6   $��Center=�6&   $��0,18,0,0q�6C   $	��Top=�6U   $��24��6m   $��28��6y   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      -   5        $	 
TxbSurname��5      $��Center=�6.   #��[ 6T   $��Center=�6�   $��	0,122,0,0q�6�   $

 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5      $��Фамилия��6   $��Center=�6*   $��0,98,0,0q�6G   $	��Top=�6Y   $��24��6q   $��50��6}   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      -   5        $	 TxbPatronymic��5      $��Center=�61   #��[ 6W   $��Center=�6�   $��	0,203,0,0q�6�   $

 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6!  �� 5      $��Отчество��6   $��Center=�6+   $��	0,179,0,0q�6H   $	��Top=�6[   $��24��6s   $��50��6   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      -   5        $	 TxbLogin��5      $��Center=�6,   #��[ 6R   $��Center=�6�   $��	0,279,0,0q�6�   $

 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5      $��
Логин��6   $��Center=�6(   $��	0,255,0,0q�6E   $	��Top=�6X   $��24��6p   $��38��6|   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      $��Пароль��6   $
��Left=�6)   $��221,331,0,0q�6D   $	��Top=�6Y   $��24��6q   $��50��6}   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      -   5        $��Добавить��5      $��Center=�6,   $��	0,579,0,0q�6I   $	��Top=�6\   $��47��6�   $	��172��6�   G� 5      -   5         G�Name$ TxbPassword��5      $��Center=�63    % !MaterialDesignOutlinedPasswordBox#��[ 6W   $��120,355,120,294q�6�   ���	#FF6F63C5
�������6�   �� 5      $��
Номер��6   $
��Left=�6(   $��221,417,0,0q�6C   $	��Top=�6X   $��24��6p   $��50��6|   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   G� 5      -   5        $ 	TxnNumber��5      $��Center=�61   #��[ 6U   $��120,441,120,208q�6�   ���	#FF6F63C5
�������6�   �� 5      -	   5        $��Добавить фото��5      $��Center=�61   $��	0,519,0,0q�6N   $	��Top=�6a   ���	#FF56AB5B���	#FF56AB5B6�   5       5!      5"      5#      