   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Leasing.Pages.WorkersPageLeasing.Pages.WorkersPage  5      1    +Leasing.Pages.WorkersPage.WorkerHistoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Leasing.Pages.WorkersPage     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  WorkerHistoryPage��5
       � 	Resources 5      0   *Leasing.Pages.WorkersPage.ImageConverterer   ByteArrayToImageConverter��%   &	          5   
   6!   5      .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   ���	#00000000.��5      �  � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $	��20* �6'    5      '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$ 30��62   6?   �� 5       � ��$ 30��63   6@   5      5      .+�5      � $��0��6   
�������.+�5      �� $��-13,17,-25,-47q�6   .@�5      �� $	��0 0q�6'   .��5      �� -   5         & "MaterialDesignFloatingActionButton#��[ 5   %   $
��Left=�6a   
���   ���5      Z� ��65   Z� .��5    "   �� $��0q�6-   .+�5!   &        Kind$	 Car=�6>   5"   #   5#      5$      �� 5*      $	��0 0q�6'   .��5+      �� #��[ 6%   $
��Left=�6a   
���   ���5,      Z� ��6   Z� .��5-   "   �� $��0q�6-   .+�5.   &     $ History=�6>   5/   #   50      51      �� 54      $��0 0 0 0q�6'   .��55      �� -   5         ��Name$ 
ExitToAuth��56   ^   #��[ 55   %   $
��Left=�6a   
���   ���56      Z� ��65   Z� .��57   "   �� $��0q�6-   .+�58   &     $ 	ExitToApp=�6>   59   #   5:      5;      5<      5=      � 5>      -   5        $��RenderPages��5>   >   $��1��6   ���	#FF221835$��	0,0,-10,0q�6Q   .+�5?      A� $
��Left=�6   $	��197��69   $��868,483,0,0q�6F   $	��Top=�6[   $	��294��6s   ���	#19FFFFFF6   A� 5@      $
��Left=�6   $	��220��69   $��-60,-166,0,0q�6F   $	��Top=�6\   $	��282��6t   ���	#19FFFFFF	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5A      V� 5B      .~�5C   "   �� �� 5D   "   �� 5E   "   
 �� Angle$
 0.133Q�62   T� 5F   "   5G      5I      �� 5J      -   5        $ CloseButton��5J   �   #��[ 6   $
��Left=�6Y   
���   �$��905,4,0,470q�6�    � Cursor$
 Hand��6�   ��6t   Z� ��6�   Z� .��5K        $ Close=�62   
�������6?   5L      &   System.Windows.Controls.DataGrid  5M      -   5          Name$ DataGR��5M      $��10,56,18,102q�6/      AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Disabled=�6a      Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ НАЗВАНИЕ��61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 131 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *Name+4	  .System.Windows.Controls.DataGridTemplateColumn	  5Q      $ ФОТО��65    	  CellTemplate 5R   "   �� 5S   &   .R�5T   *   �� $	��100��60   $	��100��6<   ��5U      �� *Images+ �� 	Converter# [  5V   '   5X        5Y      $ 
ТАРИФ��61   $ 83 6@    6K   �� *MothlyPrice+  5Z      $ ДАТА НАЧАЛА��61    6F   �� *FormattedStartDate+ �� Mode$ OneWay=�  5\      $ ДАТА КОНЦА��61    6E   �� *FormattedEndDate+$ OneWay=�  5^      $ СТАТУС��61   $	 115 6A    6M   �� *Status+5`      �� 5a      -   5        $��ОТМЕНИТЬ��5a      $
��Left=�60   $��
11,443,0,0q�6K   $	��Top=�6_   6w   �� 5b      $
��Left=�6    $��54��6;   $��11,1,0,0q�6G   $	��Top=�6Y   $��77��6q   $	 0.5,0.5&�6|   z�5c      V� 5d      .~�5e   "   �� �� 5f   "   �� 5g   "   $
 0.914Q�62   T� 5h   "   5i      ��5k      �� 5l       �� ImageSource$ /Images/newLogo.png��6)   5n      �� 5o      -   5        $��ОБНОВИТЬ��5o      $
��Left=�60   $��130,443,0,0q�6K   $	��Top=�6`   $
 Hand��6�   �� 5p      $��Ваши лизинги��6   $��Center=�63   $��0,17,0,0q�6P   $	��Top=�6b   ���	#E5FFFFFF$��18(�6�   $��Arial Black)�6�   5q      5r      5s      5t      5u      