   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRMCRM  5          CRM.Clients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:CRM     5      -   5          >�Name$  	p_Clients��5	      .��5
      � -   5         �Name$ G1��5
       � ColumnDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� ���	#FF505883$��0,0,0,-4q�6(   $��1��6:   $��2,0,0,0 q�6J   �� 5   
    �� Orientation$ 
Horizontal=�6   $��87��6.   $	��Top=�6:   $��1��6R   $��	5,9,-78,0q�6b   .+�5      �� -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Добавить��6V   $��
30,15,0,22q�6i   $	��145��6}   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Изменить��6V   $��30,0,0,22.2q�6i   $	��145��6~   $��22(�6�   $��50��6�   $��Bottom=�6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Сохранить��6V   $��
30,15,0,22q�6j   $	��145��6~   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Удалить��6V   $��
30,15,0,22q�6h   $	��145��6|   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Открыть��6V   $��
30,15,0,22q�6h   $	��145��6|   $��22(�6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dg_Clients��5      $��14,100,12,10q�6'   $��1��6>      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+	 �� Mode$	 TwoWay=�6K     5      $ 
Адрес��6N    6%   �� *	Address+$	 TwoWay=�6N     5      $ Телефон��6L    6%   �� *Phone+$	 TwoWay=�6L     5      $ E-mail��6L    6%   �� *Email+$	 TwoWay=�6L     5      $! Расчетный счет��6V    6%   �� *CheckingAccount+$	 TwoWay=�6V     5      $
 Bank��6K    6%   �� *Bank+$	 TwoWay=�6K     5      $ Директор��6O    6%   �� *
Director+$	 TwoWay=�6O     5       $ Бухгалтер��6Q    6%   �� *
Accountant+$	 TwoWay=�6Q     5!      $ Информация��6K    6%   �� *Info+$	 TwoWay=�6K   5#      5$      5%      