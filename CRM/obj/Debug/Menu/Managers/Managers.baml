   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRMCRM  5          CRM.Managers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:CRM     5      -   5          >�Name$  
p_Managers��5	      .��5      � -   5         �Name$ G1��5       � ColumnDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� ���	#FF505883$��0,0,0,-4q�6(   $��1��6:   $��2,0,0,0q�6J   �� 5   
    �� Orientation$ 
Horizontal=�6   $��87��6.   $	��Top=�6:   $��1��6R   $��	5,9,-78,0q�6b   .+�5      �� -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Добавить��6V   $��
30,15,0,22q�6i   $	��145��6}   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Изменить��6V   $��30,0,0,22.2q�6i   $	��145��6~   $��22(�6�   $��50��6�   $��Bottom=�6�   �� 5      -   5         ��Name$	 b_s��5      ���	#FF00A8AC
�������$��	Roboto Th)�6L   $��Сохранить��6c   $��
30,15,0,22q�6w   $	��145��6�   $��22(�6�   6�   �� 5      -   5        ���	#FF00A8AC
�������$��	Roboto Th)�5   ?   $��Удалить��6V   $��
30,15,0,22q�6h   $	��145��6|   $��22(�6�   6�   �� 5      -   5        $	 b_o��5      ���	#FF00A8AC
�������$��	Roboto Th)�6L   $��Открыть��6c   $��
30,15,0,22q�6u   $	��145��6�   $��22(�6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_Managers��5      $��14,100,12,10q�6w   $��1��6�      
IsReadOnly . ��6(   �� *MyList+ �� SelectedItem 6H   �� *
Selected+ �� Mode$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ФИО��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6>     5      -	   5        	dgc_login��$
 
Логин��5   R    68   �� *Login+6R     5      $
 Должность��6B    6%   �� *
Position+6B     5      $
 Группа��6?    6%   �� *Group+6?     5      -
   5        dgc_address��$
 
Адрес��5   V    6:   �� *	Address+6V     5      -   5        	dgc_phone��$
 Телефон��5   R    68   �� *Phone+6R     5       -   5        dgc_pass��$
 Пасспорт��5    T    67   �� *
Passport+6T     5!      -   5        	dgc_dateB��$
 Дата рождения��5!   X    68   �� *DateOfBirth+6X     5"      -   5        	dgc_dateR��$-
 'Дата приема на работу��5"   \    68   �� *DateRecruitment+6\     5#      $
 E-mail��6?    6%   �� *Email+6?     5$      $
 Информация��6>    6%   �� *Info+6>   5&      5'      5(      