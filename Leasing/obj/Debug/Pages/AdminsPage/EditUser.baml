   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Leasing.Pages.AdminsPageLeasing.Pages.AdminsPage  5   	   '    !Leasing.Pages.AdminsPage.EditUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Leasing.Pages.AdminsPage     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  EditUser��5	   	    � 
ResizeMode$ NoResize=�61   $	��500��6G   $
��1000��6T    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6{    � WindowStyle$
 None=�6�   
������ .��5
      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   .��5      � $��	0,0,0,-21q�6   .+�5      �� -   5         ��Name$ CloseButton��5   �    &  "MaterialDesignFloatingActionButton#��[  6   $
��Left=�6U   
���   �$��914,0,0,445q�6�    � Cursor$
 Hand��6�   ��6p   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
���   �$��39��6N   $��39��6Z   $��Center=�6e   5      �� 5      -   5        	 ��Name$	 TxbLogin��5      $��Center=�6,    ! MaterialDesignOutlinedTextBox#��[ 6R   $
��Left=�6�   $��672,200,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5      $��
Логин��6   $
��Left=�6(   $��774,176,0,0q�6C   $	��Top=�6X   $��24��6p   $��38��6|   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      $��Пароль��6   $
��Left=�6)   $��772,252,0,0q�6D   $	��Top=�6Y   $��24��6q   $��50��6}   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      -   5        $��Изменить��5      $
��Left=�6,   $��744,348,0,0q�6G   $	��Top=�6\   $
 Hand��6�   G� 5      -   5         G�Name$ TxbPassword��5      $��Center=�63    % !MaterialDesignOutlinedPasswordBox#��[ 6W   $��672,276,68,173q�6�   ���	#FF6F63C5
�������6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGR��5      $��10,58,341,101q�6+      AutoGenerateColumns .  ���	#FFE2E2E2$   HorizontalScrollBarVisibility$ Disabled=�6u      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
ЛОГИН��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 107 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Login+  5      $ ПАРОЛЬ��6-   $	 105 6=    6I   �� *
Password+  5      $ РОЛЬ��6-   $	 111 6;    6G   �� *Role+  5      $ СТАТУС��6-   $	 111 6=    6I   �� *Status+5      �� 5      -   5         ��Name$ combob��5       " MaterialDesignOutlinedComboBox#��[ 6+   $
��Left=�6c   $��772,111,0,0q�6~   $	��Top=�6�   $	��120��6�   $��55��6�   .@�5       �� $��
Админ��6#   
 � Tag$ 1��63   �� 5!      $��Рабочий��6#   $ 2��65   5"      �� 5#      $��Поменять роль��6   $
��Left=�60   $��677,124,0,0q�6K   $	��Top=�6`   $��26��6x   $��99��6�   ���	#FF7D32FF$��18(�6�   $��Bahnschrift Condensed)�6�   �� 5$      $;��5Редактирование пользователя��6   $
��Left=�6>   $��	22,19,0,0q�6Y   $	��Top=�6l   ���	#E5000000$��18(�6�   $��Arial Black)�6�   �� 5%      -   5        $ 	statusbox��5%      #��[ 6.   $
��Left=�6f   $��
772,50,0,0q�6�   $	��Top=�6�   $	��120��6�   $��55��6�   .@�5&      �� $��Работает��6#   $ 1��66   �� 5'      $��Уволен��6#   $ 2��64   5(      �� 5)      $#��Поменять статус��6   $
��Left=�62   $��
663,66,0,0q�6M   $	��Top=�6a   $��26��6y   $	��108��6�   ���	#FF7D32FF$��18(�6�   $��Bahnschrift Condensed)�6�   5*      5+      5,      5-      