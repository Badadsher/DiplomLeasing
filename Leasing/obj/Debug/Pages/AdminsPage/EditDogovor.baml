   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Leasing.Pages.AdminsPageLeasing.Pages.AdminsPage  5   	   *    $Leasing.Pages.AdminsPage.EditDogovor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Leasing.Pages.AdminsPage     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5          � Title$  EditDogovor��5	   	    � 
ResizeMode$ NoResize=�5
      $	��550��6   $
��1000��6(    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6O    � WindowStyle$
 None=�6t   
������ .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   .��5      � $��	0,0,0,-21q�6   .+�5      �� -   5         ��Name$ CloseButton��5   �    &  "MaterialDesignFloatingActionButton#��[  6   $
��Left=�6U   
���   �$��914,0,0,445q�6�    � Cursor$
 Hand��6�   ��6p   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
���   �$��39��6N   $��39��6Z   $��Center=�6e   5      �� 5      -   5        $��Изменить��5      $
��Left=�6,   $��764,469,0,0q�6G   $	��Top=�6\   6t   &   System.Windows.Controls.DataGrid  5      -   5        	  Name$	 DataGR��5      $��22,72,315,86q�6+   
   AutoGenerateColumns
 .  $   HorizontalScrollBarVisibility$ Disabled=�6]      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ АЙДИ КЛИЕНТА��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 141 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *
ClientID+  5      $ ДАТА НАЧАЛА��6-   $	 126 6B    6O   �� *FormattedStartDate+ �� Mode$ OneWay=�  5      $! ДАТА ОКОНЧАНИЯ��6-   $	 152 6E    6Q   �� *FormattedEndDate+$ OneWay=�  5      $ СТАТУС��6-   $ 85 6=    6H   �� *Status+  5      $ АЙДИ МАШИНЫ��6-   $	 140 6B    6N   �� *CarID+5      �� 5      -   5         ��Name$ 	TxbClient��5      $��Center=�6-    ! MaterialDesignOutlinedTextBox#��[ 6S   $
��Left=�6�   $��
693,84,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5      $��Айди клиента��6   $
��Left=�6/   $��
777,60,0,0q�6J   $	��Top=�6^   $��24��6v   $��72��6�   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      $!��Начала лизинга��6   $
��Left=�61   $��772,140,0,0q�6L   $	��Top=�6a   $��24��6y   $��96��6�   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      $��Конец лизинга��6   $
��Left=�60   $��776,222,0,0q�6K   $	��Top=�6`   $��24��6x   $��96��6�   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5      $��Статус��6   $
��Left=�6)   $��794,298,0,0q�6D   $	��Top=�6Y   $��24��6q   $��38��6}   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   (  "System.Windows.Controls.DatePicker  5       -   5          Name$ 	datestart��5        $  MaterialDesignOutlinedDatePicker#��[ 61   $
��Left=�6k   $��752,163,0,0q�6�   $	��Top=�6�   $��58��6�   $	��122��6�     5!      -   5        $ dateend��5!      #��[ 6/   $
��Left=�6i   $��	752,0,0,0q�6�   $��Center=�6�   $��58��6�   $	��122��6�   �� 5"      $D��>Редактирование договоров лизинга��6   $
��Left=�6C   $��	22,19,0,0q�6^   $	��Top=�6q   ���	#E5000000$��18(�6�   $��Arial Black)�6�   �� 5#      -   5        $ TxbCarID��5#      $��Center=�6,   #��[ 6R   $
��Left=�6�   $��693,402,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��240��6�   $��52��6�   ���	#FF6F63C5
�������6  �� 5$      $��Айди машины��6   $
��Left=�6.   $��776,374,0,0q�6I   $	��Top=�6^   $��24��6v   $��78��6�   ���	#FF7D32FF$��14(�6�   $��Bahnschrift Condensed)�6�   �� 5%      -	   5         ��Name$ combob��5%       " MaterialDesignOutlinedComboBox#��[ 6+   $
��Left=�6c   $��755,319,0,0q�6~   $	��Top=�6�   $	��120��6�   $��58��6�   .@�5&      �� $��В процессе��6#   
 � Tag$ 1��68   �� 5'      $��Закончен��6#   $ 2��66   5(      5)      5*      5+      5,      