   M S B A M L   `   `   `  ����p  lЛомбард_Молчанов_Комова_ИС1-33, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:Ломбард_Молчанов_Комова_ИС1_335Ломбард_Молчанов_Комова_ИС1_33  5   	   F    @Ломбард_Молчанов_Комова_ИС1_33.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:Ломбард_Молчанов_Комова_ИС1_33     5   	     � Title$  Меню��5   	   $	��454��6   $	��882��6#   .��5	      � $��-4,0,2,0q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF60CB23��6    � Offset$ 0Q�61   � 5      $ 	#FF2EE4D3��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5      $��10,10,0,248q�6$   $
��Left=�6:   $	��859��6U   ���	#FFC7C7C7
���   �
���   �6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��125,350,0,0q�6?   $	��Top=�6T   $��75��6l   $��20��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF57C8EA��6#   $
 0.11Q�65   � 5      $ 	#FFF592FF��6#   $ 1Q�65   5      5      �� 5   
   -   5        $��Изменить��5      $
��Left=�6$   $��243,239,0,0q�6?   $	��Top=�6T   $��75��6l   $��20��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5       � $ 	#FF57C8EA��6#   $
 0.11Q�65   � 5!      $ 	#FFF592FF��6#   $ 1Q�65   5"      5$      �� 5%   
   -   5        $��Удалить��5%      $
��Left=�6#   $��357,238,0,0q�6>   $	��Top=�6S   $��75��6k   $��20��6�   ��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ 	#FF57C8EA��6#   $
 0.11Q�65   � 5)      $ 	#FFF592FF��6#   $ 1Q�65   5*      5,      �� 5-   
   -   5        $��idtovara��5-   9   $
��Left=�6   $��19��6-   $��312,182,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5.   
   -   5        $��	idklienta��5.   9   $
��Left=�6   $��19��6-   $��112,182,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5/   
   -   5        $��Nazvanie��5/   9   $
��Left=�6   $��19��6-   $��112,230,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 50   
   -   5        $	��Ves��50   9   $
��Left=�6   $��19��6-   $��112,254,0,0q�6D   $
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��120��6�   �� 51   
   -	   5        $��
datazaloga��51   9   $
��Left=�6   $��19��6-   $��112,278,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 52   
   -
   5        $��
datavikupa��52   9   $
��Left=�6   $��19��6-   $��112,302,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 53   
   -   5        $��chena��53   9   $
��Left=�6   $��19��6-   $��112,326,0,0q�6F   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 54   
   $
��Left=�6   $��243,185,0,0q�6/   $
��Wrap=�6D   $��id_Товара��6X   $	��Top=�6i   $��16��6�   $��54��6�   �� 55   
   $
��Left=�6   $��
14,182,0,0q�6/   $
��Wrap=�6C   $��Номер клиента��6W   $	��Top=�6l   $��16��6�   $��93��6�   �� 56   
   $
��Left=�6   $��243,209,0,0q�6/   $
��Wrap=�6D   $��Статус��6X   $	��Top=�6f   $��16��6~   $��35��6�   �� 57   
   $
��Left=�6   $��
14,232,0,0q�6/   $
��Wrap=�6C   $��Название��6W   $	��Top=�6g   $��16��6   $��93��6�   �� 58   
   $
��Left=�6   $��
14,256,0,0q�6/   $
��Wrap=�6C   $��Вес в Гр.��6W   $	��Top=�6h   $��16��6�   $��98��6�   �� 59   
   $
��Left=�6   $��
14,280,0,0q�6/   $
��Wrap=�6C   $��Дата залога��6W   $	��Top=�6j   $��16��6�   $��93��6�   �� 5:   
   $
��Left=�6   $��
14,304,0,0q�6/   $
��Wrap=�6C   $��Дата выкупа��6W   $	��Top=�6j   $��16��6�   $��93��6�   �� 5;   
   $
��Left=�6   $��
14,328,0,0q�6/   $
��Wrap=�6C   $��Цена��6W   $	��Top=�6c   $��16��6{   $��93��6�   �� 5<   
   $
��Left=�6   $��
14,206,0,0q�6/   $
��Wrap=�6C   $��Вид��6W   $	��Top=�6b   $��16��6z   $��93��6�   �� 5=   
   -   5        $��Status��5=   .   $
��Left=�6   $��312,206,0,0q�6<   $	��Top=�6Q   $	��120��6i   $��21��6u   .@�5>      �� $��Ожидает��6   $
��Left=�6-   $	��118��6H   �� 5?      $��Просрочен��6   $
��Left=�6/   $	��118��6J   �� 5@      $��Выкуплен��6   $
��Left=�6.   $	��118��6I   5A      �� 5B   
   -   5         ��Name$ idvida��5B   .   $
��Left=�6   $��112,206,0,0q�6>   $	��Top=�6S   $	��120��6k   $��21��6w   .@�5C      �� $��Техника��6   $
��Left=�6-   $	��118��6H   �� 5D      $��Ювелирка��6   $
��Left=�6.   $	��118��6I   �� 5E      $)��#Старинные предметы��6   $
��Left=�68   $	��118��6S   5F      �� 5G   
   -   5        $��Новый клиент��5G      $
��Left=�6(   $��243,263,0,0q�6C   $	��Top=�6X   $	��189��6p   $��20��6|   ��5H      �� 5I      $ 0.5,1&�6&   $ 0.5,0&�67   .��5J      � $ 	#FF57C8EA��6#   $
 0.11Q�65   � 5K      $ 	#FFF592FF��6#   $ 1Q�65   5L      5N      5O      5P      