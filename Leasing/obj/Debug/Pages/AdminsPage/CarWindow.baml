   M S B A M L   `   `   `  ����B  >Leasing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Leasing.Pages.AdminsPageLeasing.Pages.AdminsPage  5   	   (    "Leasing.Pages.AdminsPage.CarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Leasing.Pages.AdminsPage     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  	CarWindow��5	   	   {�. $	��357��6C   $	��695��6P    � 
ResizeMode$ NoResize=�6\    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�   
������ .��5
      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 20Q�6*   .��5      � $��	0,0,0,-21q�6   .+�5      �� -   5         ��Name$ CloseButton��5       &  "MaterialDesignFloatingActionButton#��[  5      $
��Left=�5      
���   �$��612,6,0,296q�5       � Cursor$
 Hand��5      ��5      Z� ��5      Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
���   �$��39��6N   $��39��6Z   5      � 5      $
��Left=�6   $��	38,81,0,0q�62   $	��Top=�6E   .+�5      �� -   5        	 ��Name$	 myImage��5      $	��250��6-   $	��200��69   $��UniformToFill=�6F   5      �� 5      -   5        
 ��Name$
 	nameLabel��5      $��Название:��6+   $
��Left=�6?   $��
318,80,0,0q�6Z   $	��Top=�6n   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��116��6�   �� 5      -   5        $
 statusLabel��5      $��Статус:��6-   $
��Left=�6?   $��318,107,0,0q�6Z   $	��Top=�6o   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��250��6�   �� 5      -   5        $
 
priceLabel��5      $��	Цена:��6,   $
��Left=�6<   $��318,134,0,0q�6W   $	��Top=�6l   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��48��6�   $	��250��6�   �� 5      -   5        $
 
tarifLabel��5      $��Тариф:��6,   $
��Left=�6=   $��318,163,0,0q�6X   $	��Top=�6m   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��250��6�   �� 5       -   5        $
 
countLabel��5       $��	Срок:��6,   $
��Left=�6<   $��318,190,0,0q�6W   $	��Top=�6l   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��47��6�   $	��250��6�   �� 5!      -	   5        $
 avanceLabel��5!      $��Аванс:��6-   $
��Left=�6>   $��318,216,0,0q�6Y   $	��Top=�6n   ���	#E5000000$��18(�6�   $��Arial Black)�6�   $��52��6�   $	��250��6�   �� 5"      -
   5        $
 nameBox��5"      $��Название��6)   $
��Left=�6<   $��
428,81,0,0q�6W   $	��Top=�6k   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��47��6�   $	��184��6�   �� 5#      -   5        $
 	statusBox��5#      $��Название��6+   $
��Left=�6>   $��394,108,0,0q�6Y   $	��Top=�6n   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��47��6�   $	��218��6�   �� 5$      -   5        $
 priceBox��5$      $��Название��6*   $
��Left=�6=   $��380,136,0,0q�6X   $	��Top=�6m   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��47��6�   $	��232��6�   �� 5%      -   5        $
 tarifBox��5%      $��Название��6*   $
��Left=�6=   $��394,164,0,0q�6X   $	��Top=�6m   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��47��6�   $	��220��6�   �� 5&      -   5        $
 countBox��5&      $��Название��6*   $
��Left=�6=   $��378,191,0,0q�6X   $	��Top=�6m   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��47��6�   $	��232��6�   �� 5'      -   5        $
 	avanceBox��5'      $��Название��6+   $
��Left=�6>   $��388,218,0,0q�6Y   $	��Top=�6n   ���	#E5888888$��18(�6�   $��Bahnschrift SemiBold)�6�   $��48��6�   $	��226��6�   5)      5*      5+      5,      