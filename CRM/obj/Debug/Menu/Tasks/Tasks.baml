   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRMCRM  5          	CRM.Tasks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:CRM     5      -   5          >�Name$  p_Tasks��5	      .��5
      � -   5         �Name$ G1��5
       � ColumnDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� ���	#FF505883$��0,0,0,-4q�6(   $��1��6:   $��2,0,0,0q�6J   �� 5   
    �� Orientation$ 
Horizontal=�6   $��87��6.   $	��Top=�6:   $��1��6R   $��	5,9,-78,0q�6b   .+�5      �� -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Добавить��6V   $��
30,15,0,22q�6i   $	��145��6}   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Изменить��6V   $��
30,15,0,22q�6i   $	��145��6}   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Сохранить��6V   $��
30,15,0,22q�6j   $	��145��6~   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Удалить��6V   $��
30,15,0,22q�6h   $	��145��6|   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Открыть��6V   $��
30,15,0,22q�6h   $	��145��6|   $��22(�6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_Tasks��5      $��14,100,12,10q�6%   $��1��6;      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6<     5      $ Заказчик��6@    6%   �� *Client+6@     5      $ Исполнитель��6A    6%   �� *	Manager+6A     5      $ Задача��6>    6%   �� *Task+6>     5      $ Дата начала��6C    6%   �� *	DateStart+6C     5      $# Дата завершения��6F    6%   �� *DateComplete+6F     5      $ Информация��6>    6%   �� *Info+6>     5       $ Статус��6@    6%   �� *Status+6@   5"      5#      5$      